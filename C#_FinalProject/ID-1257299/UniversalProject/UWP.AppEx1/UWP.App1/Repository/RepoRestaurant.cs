using ConPJ1.DataInMemory;
using ConPJ1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.Repository
{
    class RepoProduct : IRepository<Product>, IRepository
    {
        IData<Product> db = new ProductsData();
        public Product Add(Product obj)
        {
            obj = db.Add(obj); 
            return obj;
        }

        public Product Get(long id)
        {
            return db.Get(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.GetAll();
        }

        public bool Remove(long id)
        {
            return db.Remove(id);
        }

        public bool Remove(Product obj)
        {
            return db.Remove(obj);
        }
       
        public Product Update(Product obj)
        {
            return db.Update(obj);
        }
    
    }//c
}//ns
