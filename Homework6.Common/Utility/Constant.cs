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
    }
}
