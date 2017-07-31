using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Homework6.Common.Utility;
using Homework6.JD.Service;
using Homework6.IService.Lucene;
using Homework6.Lucene.Service.JD;
using Homework6.Model.JD;
using Homework6.Redis.Service;

namespace Homework6.Lucene.JD
{
    public class IndexBuilderPerThread
    {
        private Logger logger = new Logger(typeof(IndexBuilderPerThread));
        private int CurrentThreadNum = 1;
        private string PathSuffix = "";
        private CancellationTokenSource CTS = null;
        private static RedisListService service = null;
        static IndexBuilderPerThread()
        {
            try
            {
                service = new RedisListService(); //第1次尝试开启RedisListService服务
            }
            catch { }
        }

        public IndexBuilderPerThread(int threadNum, string pathSuffix, CancellationTokenSource cts)
        {
            this.CurrentThreadNum = threadNum;
            this.PathSuffix = pathSuffix;
            this.CTS = cts;
        }

        public void Process()
        {

            try
            {
                logger.Debug(string.Format("ThreadNum={0}开始创建", CurrentThreadNum));
                CommodityRepository commodityRepository = new CommodityRepository();
                ILuceneBulid builder = new LuceneBulid();
                bool isFirst = true;
                int pageIndex = 1;
                while (!CTS.IsCancellationRequested)
                {
                    List<Commodity> commodityList;
                    if (service == null)
                    {
                        commodityList = commodityRepository.QueryList(CurrentThreadNum, pageIndex, 1000);
                    }
                    else
                    {
                        //新增代码，从Redis逐行获取
                        var result = service.BlockingPopItemFromList("commodity", TimeSpan.FromHours(3));
                        commodityList = new List<Commodity> { JsonHelper.JsonToObj<Commodity>(result) };
                    }
                    if (service == null && (commodityList == null || commodityList.Count == 0))
                    {
                        break;
                    }
                    //else if (pageIndex == 11)
                    //{
                    //    break;//为了测试  只做10000条数据
                    //}
                    else
                    {
                        builder.BuildIndex(commodityList, PathSuffix, isFirst);
                        logger.Debug(string.Format("ThreadNum={0}完成{1}条的创建", CurrentThreadNum, 1000 * pageIndex++));
                        isFirst = false;
                    }
                }
            }
            catch (Exception ex)
            {
                CTS.Cancel();
                logger.Error(string.Format("ThreadNum={0}出现异常", CurrentThreadNum), ex);
            }
            finally
            {
                logger.Debug(string.Format("ThreadNum={0}完成创建", CurrentThreadNum));
            }
        }
    }
}
