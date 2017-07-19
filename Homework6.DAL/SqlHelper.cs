using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Homework6.Model;
using System.Data.SqlClient;
using Homework6.IDAL;

namespace Homework6.DAL
{
    public class SqlHelper : IDBHelper
    {
        //更新代码：做成静态，免得每次都要去读配置文件
        private static string sConn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        //新增委托事件方法，美化代码
        private static T ExecuteAction<T>(Func<SqlCommand, T> execSql)
        {
            Type type = typeof(T);
            T t = default(T);
            using (SqlConnection conn = new SqlConnection(sConn))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                conn.Open();
                t = execSql(command);
            }
            return t;
        }

        public int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(sConn))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = sql;
                conn.Open();
                return command.ExecuteNonQuery();
            }
        }

        public int Add<T>(T t, string tableName = null) where T : BaseModel
        {
            int iResult = ExecuteAction(cmd =>
            {
                Type type = typeof(T);
                string fieldList = string.Join(",", type.GetProperties()
                                                        .Where(p => !p.Name.Equals("Id"))
                                                        .Select(p => string.Format("[{0}]", p.Name)));
                //更新代码：将valueList 替换参数型 parameterList
                string parameterList = string.Join(",", type.GetProperties()
                                                        .Where(p => !p.Name.Equals("Id"))
                                                        .Select(p => string.Format("@{0}", p.Name)));
                //新增代码：带参数部分
                var pvList = type.GetProperties()
                                 .Where(p => !p.Name.Equals("Id"))
                                 .Select(p => new SqlParameter
                                 {
                                     ParameterName = string.Format("@{0}", p.Name),
                                     Value = p.GetValue(t) ?? DBNull.Value
                                 }).ToArray();

                var sql = string.Format("insert into [{0}]({1}) values({2})", tableName ?? type.Name, fieldList, parameterList);
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(pvList);
                return cmd.ExecuteNonQuery();
            });

            return iResult;
        }


        public int Update<T>(T t, string tableName = null) where T : BaseModel
        {
            int iResult = ExecuteAction(cmd =>
            {
                Type type = typeof(T);
                string fieldList = string.Join(",", type.GetProperties()
                                                        .Where(p => !p.Name.Equals("Id"))
                                                        .Select(p => string.Format("[{0}]=@{0}", p.Name)));
                //新增代码：带参数部分
                var pvList = type.GetProperties()
                                 .Where(p => !p.Name.Equals("Id"))
                                 .Select(p => new SqlParameter
                                 {
                                     ParameterName = string.Format("@{0}", p.Name),
                                     Value = p.GetValue(t) ?? DBNull.Value
                                 }).ToArray();

                string sql = string.Format("update [{0}] set {1}  where id={2}", tableName ?? type.Name, fieldList, t.Id);
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(pvList);
                return cmd.ExecuteNonQuery();
            });

            return iResult;
        }


        public int Delete<T>(int id, string tableName = null) where T : BaseModel
        {
            int iResult = ExecuteAction(cmd =>
            {
                Type type = typeof(T);
                string sql = string.Format("delete from [{0}] where id={1}", tableName ?? typeof(T).Name, id);
                cmd.CommandText = sql;
                return cmd.ExecuteNonQuery();
            });

            return iResult;
        }

        public T GetById<T>(int id, string tableName = null) where T : BaseModel
        {
            T t = ExecuteAction(cmd =>
            {
                Type type = typeof(T);
                string fieldList = string.Join(",", type.GetProperties().Select(s => string.Format("[{0}]", s.Name)));
                string sql = string.Format(@"select {0} from [{1}] where id={2}",
                                        fieldList, tableName ?? type.Name, id);
                var obj = Activator.CreateInstance<T>();
                cmd.CommandText = sql;
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    foreach (var item in type.GetProperties())
                    {
                        item.SetValue(obj, dr[item.Name]);
                    }
                }
                return obj;
            });
            return t;
        }

        public List<T> GetALL<T>(string sWhere = null) where T : BaseModel
        {
            return ExecuteAction(command =>
            {
                List<T> ts = new List<T>();
                Type type = typeof(T);
                string fieldList = string.Join(",",
                                             type.GetProperties()
                                                 .Select(p => string.Format("[{0}]", p.Name)));
                string sql = string.Format("select {0} from [{1}] ", fieldList, tableName ?? type.Name);
                if (sWhere != null)
                {
                    sql += sWhere;
                }
                command.CommandText = sql;
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    T t = Activator.CreateInstance<T>();
                    foreach (var item in type.GetProperties())
                    {
                        //更新代码：解决System.ArgumentException:类型System.DBNull的对象无法转换为类型System.String。
                        if (dr[item.Name] is DBNull)
                        {
                            item.SetValue(t, null);
                        }
                        else
                        {
                            item.SetValue(t, dr[item.Name]);
                        }
                    }
                    ts.Add(t);
                }
                return ts;
            });
        }

        public int InsertList<T>(IEnumerable<T> ts, string tableName = null) where T : BaseModel
        {
            int iResult = ExecuteAction(cmd =>
            {
                Type type = typeof(T);
                StringBuilder sbSql = new StringBuilder();
                foreach (var t in ts)
                {
                    string fieldList = string.Join(",", type.GetProperties()
                                                        .Where(p => !p.Name.Equals("Id"))
                                                        .Select(p => string.Format("[{0}]", p.Name)));
                    //更新代码：将valueList 替换参数型 parameterList
                    string parameterList = string.Join(",", type.GetProperties()
                                                            .Where(p => !p.Name.Equals("Id"))
                                                            .Select(p => string.Format("@{0}", p.Name)));
                    //新增代码：带参数部分
                    var pvList = type.GetProperties()
                                     .Where(p => !p.Name.Equals("Id"))
                                     .Select(p => new SqlParameter
                                     {
                                         ParameterName = string.Format("@{0}", p.Name),
                                         Value = p.GetValue(t) ?? DBNull.Value
                                     }).ToArray();

                    cmd.Parameters.AddRange(pvList);
                    var sql = string.Format("insert into [{0}]({1}) values({2});", tableName ?? type.Name, fieldList, parameterList);
                    sbSql.Append(sql);
                }

                cmd.CommandText = sbSql.ToString();
                return cmd.ExecuteNonQuery();
            });

            return iResult;
        }
    }
}
