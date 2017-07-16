using System.Collections.Generic;
using Homework6.Model;

namespace Homework6.IDAL
{
    public interface IDBHelper
    {
        int ExecuteNonQuery(string sql);
        int Add<T>(T t) where T : BaseModel;
        //      int InsertList<IEnumerable<in T>>(IEnumerable<T> ts) where T:BaseModel
        int Delete<T>(int id) where T : BaseModel;
        List<T> GetALL<T>(string sWhere = null) where T : BaseModel;
        T GetById<T>(int id) where T : BaseModel;
        int Update<T>(T t) where T : BaseModel;
    }
}