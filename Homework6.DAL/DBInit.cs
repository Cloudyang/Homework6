﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.Common.Utility;

namespace Homework6.DAL
{
    /// <summary>
    /// 数据库结构初始化
    /// 改进下：直接判断表是否存在，而不是等着异常
    /// </summary>
    public class DBInit
    {
        private static Logger logger = new Logger(typeof(DBInit));
        private static SqlHelper sqlHelper = new SqlHelper();

        /// <summary>
        /// 谨慎使用  会全部删除数据库并重新创建！
        /// </summary>
        public static void InitCommodityTable(string sourceName,int num=31)
        {
            #region Delete
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i < num; i++)
                {
                    sb.AppendFormat($"DROP TABLE [dbo].[{sourceName}_Commodity_{ i.ToString("000")}];");
                }
                sqlHelper.ExecuteNonQuery(sb.ToString());
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("因为它不存在，或者您没有所需的权限。"))
                {
                    logger.Warn("初始化数据库InitCommodityTable删除的时候，原表不存在");
                }
                else
                {
                    logger.Error("初始化数据库InitCommodityTable失败", ex);
                    //throw ex;
                }
            }
            #endregion Delete

            #region Create
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i < num; i++)
                {
                    sb.AppendFormat(@"CREATE TABLE [dbo].[{1}_Commodity_{0}](
	                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                    [ProductId] [bigint] NULL,
	                                    [CategoryId] [int] NULL,
	                                    [Title] [nvarchar](500) NULL,
	                                    [Price] [decimal](18, 2) NULL,
	                                    [Url] [varchar](1000) NULL,
	                                    [ImageUrl] [varchar](1000) NULL,
                             CONSTRAINT [PK_JD_Commodity_{0}] PRIMARY KEY CLUSTERED 
                            (
                            	[Id] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY];", i.ToString("000"),sourceName);
                }
                sqlHelper.ExecuteNonQuery(sb.ToString());
            }
            catch (Exception ex)
            {
                logger.Error("InitCommodityTable创建异常", ex);
                throw ex;
            }
            #endregion Create
        }

        /// <summary>
        /// 谨慎使用  会全部删除数据库并重新创建！
        /// </summary>
        public static void InitCategoryTable(string sourcename)
        {
            #region Delete
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"DROP TABLE [dbo].[{sourcename}_Category];");
                sqlHelper.ExecuteNonQuery(sb.ToString());
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("无法对 表 'dbo.Category' 执行 删除，因为它不存在，或者您没有所需的权限。"))
                {
                    logger.Warn("初始化数据库InitCategoryTable删除的时候，原表不存在");
                }
                else
                {
                    logger.Error("初始化数据库InitCategoryTable失败", ex);
                   // throw ex;
                }
            }
            #endregion Delete

            #region Create
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($@"CREATE TABLE [dbo].[{sourcename}_Category](
	                                    [Id] [int] IDENTITY(1,1) NOT NULL,
	                                    [Code] [varchar](100) NULL,
	                                    [ParentCode] [varchar](100) NULL,
	                                    [CategoryLevel] [int] NULL,
	                                    [Name] [nvarchar](50) NULL,
	                                    [Url] [varchar](1000) NULL,
	                                    [State] [int] NULL,
                                      CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
                                     (
                                     	[Id] ASC
                                     )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                                     ) ON [PRIMARY];");

                sqlHelper.ExecuteNonQuery(sb.ToString());
            }
            catch (Exception ex)
            {
                logger.Error("初始化数据库InitCategoryTable 创建失败", ex);
                throw ex;
            }
            #endregion Create

        }
    }
}
