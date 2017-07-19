using Homework6.Common.Utility;
using Homework6.Crawler.JD;
using Homework6.IService;
using Homework6.JD.Service;
using Homework6.Model.JD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnJDCrawler_Click(object sender, EventArgs e)
        {
            //#region 测试DownloadHtml
            //string html = HttpHelper.DownloadHtml(@"https://list.jd.com/list.html?cat=9987,653,655", Encoding.UTF8);
            //#endregion

            //#region 测试获取分类页
            ////string html1 = HttpHelper.DownloadHtml(Constant.JDCategoryUrl, Encoding.UTF8);
            //#endregion


            //#region 测试抓取商品列表
            //string testCategory = "{\"Id\":73,\"Code\":\"02f01s01T\",\"ParentCode\":\"02f01s\",\"Name\":\"烟机/灶具\",\"Url\":\"http://list.jd.com/list.html?cat=737,13297,1300\",\"Level\":3}";
            //Category category = JsonHelper.JsonToObj<Category>(testCategory);
            //ISearch search = new CommoditySearch(category);
            //search.Crawler();
            //#endregion

            #region 抓取
            CrawlerCenter.Handler();
            #endregion

        }
    }
}
