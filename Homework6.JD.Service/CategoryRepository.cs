﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.Common.Utility;
using Homework6.IDAL;
using Homework6.Model.JD;

namespace Homework6.JD.Service
{
    public class CategoryRepository //: IRepository<Commodity>
    {
        private static readonly string tableName = "JD_Category";
        private Logger logger = new Logger(typeof(CategoryRepository));
        private static IDBHelper sqlHelper = new Homework6.DAL.SqlHelper();

        public void Save(List<Category> categoryList)
        {
            sqlHelper.InsertList<Category>(categoryList, tableName);
            Task.Run(() =>
            {
                SaveList(categoryList);
            });
        //    new Action<List<Category>>(SaveList).BeginInvoke(categoryList, null, null);
        }

        /// <summary>
        /// 根据Level获取类别列表
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public List<Category> QueryListByLevel(int level)
        {
            // string sql = string.Format("SELECT * FROM category WHERE categorylevel={0};", level);
            //    return SqlHelper.QueryList<Category>(sql);
            return sqlHelper.GetALL<Category>($"WHERE categorylevel={level}", tableName);
        }


        /// <summary>
        /// 存文本记录的
        /// </summary>
        /// <param name="categoryList"></param>
        public void SaveList(List<Category> categoryList)
        {
            StreamWriter sw = null;
            try
            {
                string recordFileName = string.Format("{0}_Category.txt", DateTime.Now.ToString("yyyyMMddHHmmss"));
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

                //   sw.WriteLine(JsonConvert.SerializeObject(categoryList));
                sw.WriteLine(JsonHelper.ObjToString(categoryList));
            }
            catch (Exception e)
            {
                logger.Error("CategoryRepository.SaveList出现异常", e);
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
    }
}
