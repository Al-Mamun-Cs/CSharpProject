using System.Collections.Generic;

namespace ConPJ1.DataInMemory
{
    interface IData<T> where T : class
    {
        void LoadSampleData();
        IEnumerable<T> GetAll();
        T Get(long id);
        T Get(string name);
        IEnumerable<T> GetByName(string name);
        T Add(T obj);
        bool Remove(long id);
        bool Remove(T obj);
        T Update(T obj);
    }
}
