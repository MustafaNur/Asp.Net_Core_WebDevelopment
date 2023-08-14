using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenricDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Upadate(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
