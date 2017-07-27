using System.Collections.Generic;
using Homework6.Model;

namespace Homework6.IDAL
{
    public interface IDBHelper
    {
        int ExecuteNonQuery(string sql);
        int Add<T>(T t, string tableName = null) where T : BaseModel;
        int InsertList<T>(IEnumerable<T> ts, string tableName = null) where T : BaseModel;
        int Delete<T>(int id, string tableName = null) where T : BaseModel;
        List<T> GetALL<T>(string sWhere = null, string tableName = null) where T : BaseModel;
        T GetById<T>(int id, string tableName = null) where T : BaseModel;
        int Update<T>(T t, string tableName = null) where T : BaseModel;
        List<T> QueryList<T>(string sql);
    }
}