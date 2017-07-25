using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Common.Utility
{
    /// <summary>
    /// 系统配置项
    /// </summary>
    public class Constant
    {
        /// <summary>
        /// 数据文件保存路径
        /// </summary>
        public static string DataPath = ConfigurationManager.AppSettings["JDDataPath"];
        /// <summary>
        /// 京东类别入口
        /// </summary>
        public static string JDCategoryUrl = ConfigurationManager.AppSettings["JDCategoryUrl"];

        /// <summary>
        /// 多线程控制信号量 默认开启
        /// </summary>
        public static System.Threading.ManualResetEvent MRE = new System.Threading.ManualResetEvent(true);

        /// <summary>
        /// 多线程公有信号量
        /// </summary>
        public static System.Threading.CancellationTokenSource CTS;  //在主线程调用时 btnJDCrawler_Click 初始化

    }
}
