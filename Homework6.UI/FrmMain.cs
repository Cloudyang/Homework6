using Homework6.Common.Utility;
using Homework6.Crawler.JD;
using Homework6.IService.Crawler;
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
            ///初始化信号量
            Constant.CTS = new System.Threading.CancellationTokenSource();

            #region 抓取
            Task.Run(() =>
            {
                CrawlerCenter.Handler(dgvCrawler_Update);
            }).ContinueWith(t =>
            {
                base.Invoke(new Action(() =>
                {
                    ((Button)sender).Enabled = true;
                    btnStop.Enabled = true;
                    btnCleanData.Enabled = true;
                }));
            }
            );
            #endregion
            ((Button)sender).Enabled = false;
            btnResume.Enabled = false;
            btnCleanData.Enabled = false;
        }

        private void dgvCrawler_Update(List<Category> obj)
        {
            Invoke(new Action(()=> {
                dgvCrawler.DataSource = obj;
                dgvCrawler.Update();
            }));
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Constant.MRE.Set();
            btnResume.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Constant.MRE.Reset();
            btnResume.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Constant.CTS.Cancel();

            ((Button)sender).Enabled = false;
        }

        private void btnCleanData_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                CrawlerCenter.CleanAll();
            }).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    btnJDCrawler.Enabled = true;
                }));
            });
            btnCleanData.Enabled = false;
        }
    }
}
