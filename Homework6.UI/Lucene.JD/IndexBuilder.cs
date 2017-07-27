using Homework6.Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Homework6.IService.Lucene;
using Homework6.Lucene.Service.JD;

namespace Homework6.Lucene.JD
{
    /// <summary>
    /// 索引建立
    /// </summary>
    public class IndexBuilder
    {
        private static Logger logger = new Logger(typeof(IndexBuilder));
        private static List<string> PathSuffixList = new List<string>();
        private static CancellationTokenSource CTS = new CancellationTokenSource();

        public static void Build()
        {
            try
            {
                logger.Debug(string.Format("{0} BuildIndex开始",DateTime.Now));
                for (int i = 0; i < 31; i++)
                {
                    IndexBuilderPerThread thread = new IndexBuilderPerThread(i+1, i.ToString("000"), CTS);
                    thread.Process();
                }

                //List<Task> taskList = new List<Task>();
                //TaskFactory taskFactory = new TaskFactory();
                //CTS = new CancellationTokenSource();

                //for (int i = 1; i < 31; i++)
                //{
                //    IndexBuilderPerThread thread = new IndexBuilderPerThread(i, i.ToString("000"), CTS);
                //    PathSuffixList.Add(i.ToString("000"));
                //    taskList.Add(taskFactory.StartNew(thread.Process));//开启一个线程   里面创建索引
                //}
                //taskList.Add(taskFactory.ContinueWhenAll(taskList.ToArray(), MergeIndex));
                //Task.WaitAll(taskList.ToArray());
                logger.Debug(string.Format("BuildIndex{0}", CTS.IsCancellationRequested ? "失败" : "成功"));
            }
            catch (Exception ex)
            {
                logger.Error("BuildIndex出现异常", ex);
            }
            finally
            {
                logger.Debug(string.Format("{0} BuildIndex结束", DateTime.Now));
                CTS = null;
            }
        }

        private static void MergeIndex(Task[] tasks)
        {
            try
            {
                if (CTS.IsCancellationRequested) return;
                ILuceneBulid builder = new LuceneBulid();
                builder.MergeIndex(PathSuffixList.ToArray());
            }
            catch (Exception ex)
            {
                CTS.Cancel();
                logger.Error("MergeIndex出现异常", ex);
            }
        }
    }
}
