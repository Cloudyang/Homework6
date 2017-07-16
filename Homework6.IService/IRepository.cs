using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.IService
{
    public interface IRepository<T> where T : class//, new()
    {
        void Save(T entity);
        void SaveList(List<T> entity);
    }
}
