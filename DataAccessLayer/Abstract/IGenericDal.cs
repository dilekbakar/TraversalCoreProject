using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T entity);
        void Delete(T entity);  
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
    }
}
