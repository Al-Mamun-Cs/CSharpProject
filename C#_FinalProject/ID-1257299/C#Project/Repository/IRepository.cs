using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1
{
   internal interface IRepository<T> where T : class
    {
        T Add(T obj); 
        T Get(long id);
        T Name(string name);
        IEnumerable<T> GetAll();
        T Update(T obj);
        bool Remove(long id);
        bool Remove(T obj);
        
    }//i
}//ns 
