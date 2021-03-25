using System.Collections.Generic;

namespace ConPJ1.Repository
{
    public interface IRepository { }
    public interface IRepository<T> where T : class
    {
        T Add(T obj);
        T Get(long id);
        IEnumerable<T> GetAll();
        T Update(T obj);
        bool Remove(long id);
        bool Remove(T obj);
    }//i
}//ns
