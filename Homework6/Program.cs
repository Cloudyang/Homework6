using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            //var webclient = new WebClientDemo("https://www.baidu.com");
            //var html = webclient.GetHtml();
            //Console.WriteLine(html);
            var webhelper = new MyWebHelper("https://www.baidu.com");
            var html = webhelper.GetHtml();
            Console.WriteLine(html);

            Console.ReadLine();
        }
    }

    class MyWebHelper
    {
        private string _url;
        public MyWebHelper(string url)
        {
            this._url = url;
        }

        public virtual string GetHtml()
        {
            string sResult = string.Empty;
            WebRequest request = HttpWebRequest.Create(_url);
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                using (Stream stream = response.GetResponseStream())
                {
                    Encoding enc = Encoding.GetEncoding("utf-8");
                    using(StreamReader sr=new StreamReader(stream, enc))
                    {
                        sResult = sr.ReadToEnd();
                    }
                }
            }
            return sResult;
        }
    }

    class WebClientDemo
    {
        private string _url;
        public WebClientDemo(string url)
        {
            this._url = url;
        }

        public string GetHtml()
        {
            string sResult = string.Empty;
            using (WebClient wc = new WebClient())
            {
                wc.Credentials = CredentialCache.DefaultCredentials;

                //方法一
                //{
                //    Encoding enc = Encoding.GetEncoding("utf-8");
                //    byte[] pageData = wc.DownloadData(_url);
                //    sResult = enc.GetString(pageData);
                //}

                //方法二
                using (Stream stream = wc.OpenRead(_url))
                {
                    Encoding enc = Encoding.GetEncoding("utf-8");
                    using (StreamReader sr = new StreamReader(stream, enc))
                    {
                        sResult = sr.ReadToEnd();
                    }
                }

            }
            return sResult;
        }
    }
}