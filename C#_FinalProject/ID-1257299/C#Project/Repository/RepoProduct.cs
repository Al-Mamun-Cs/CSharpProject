using ConPJ1.DataInMemory;
using ConPJ1.DBSource;
using ConPJ1.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1
{
    public interface IRepository
    {

    }
    public class RepoProduct : IRepository<Product>,IRepository

    {
        ProductData db = new ProductData();
        public Product Add(Product obj)
        {
            return db.Add(obj);
        }

        public Product Get(long id)
        {
           return db.Get(id);
        }
        

        public IEnumerable<Product> GetAll()
        {
            return db.GetAll();
        }

        public IEnumerable<Product> GetByName(string name)
        {
            return db.GetAll();
        }

        public Product Name(string name)
        {

            return db.Name(name);
        }
        public bool Remove(long id)
        {
           return db.Remove(id);
        }

        public bool Remove(Product svm)
        {
            return db.Remove(svm);
        }

        public Product Update(Product svm)
        {
            return db.Update(svm);
        }
    }

}
