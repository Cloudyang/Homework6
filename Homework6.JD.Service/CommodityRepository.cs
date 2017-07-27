using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.Model.JD;
using Homework6.Common.Utility;
using Homework6.IDAL;
using Homework6.DAL;

namespace Homework6.JD.Service
{
    public class CommodityRepository //: IRepository<Commodity>
    {
        private Logger logger = new Logger(typeof(CommodityRepository));
        private static IDBHelper sqlHelper = new SqlHelper();

        public void SaveList(List<Commodity> commodityList)
        {
            if (commodityList == null || commodityList.Count == 0) return;
            IEnumerable<IGrouping<string, Commodity>> group = commodityList.GroupBy<Commodity, string>(c => GetTableName(c));

            foreach (var data in group)
            {
                sqlHelper.InsertList<Commodity>(data.ToList(), data.Key);
            }
        }

        private string GetTableName(Commodity commodity)
        {
            return string.Format("JD_Commodity_{0}", (commodity.ProductId % 30 + 1).ToString("000"));
        }

        /// <summary>
        /// 保存文本记录
        /// </summary>
        /// <param name="commodityList"></param>
        /// <param name="category"></param>
        /// <param name="page"></param>
        public void SaveList(List<Commodity> commodityList, Category category, int page)
        {
            StreamWriter sw = null;
            try
            {
                string recordFileName = string.Format($"{category.CategoryLevel}/{category.ParentCode}/{category.Id}/{page}.txt");
                string totolPath = Path.Combine(Constant.DataPath, recordFileName);
                if (!Directory.Exists(Path.GetDirectoryName(totolPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(totolPath));
                    sw = File.CreateText(totolPath);
                }
                else
                {
                    sw = File.AppendText(totolPath);
                }
                sw.WriteLine(JsonHelper.ObjToString(commodityList));
            }
            catch (Exception e)
            {
                logger.Error("CommodityRepository.SaveList出现异常", e);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        /// <summary>
        /// 分页获取商品数据
        /// </summary>
        /// <param name="tableNum"></param>
        /// <param name="pageIndex">从1开始</param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public List<Commodity> QueryList(int tableNum, int pageIndex, int pageSize)
        {
            string sql = string.Format("SELECT top {2} * FROM JD_Commodity_{0} WHERE id>{1};", tableNum.ToString("000"), pageSize * Math.Max(0, pageIndex - 1), pageSize);
            return sqlHelper.QueryList<Commodity>(sql);
        }
    }
}
