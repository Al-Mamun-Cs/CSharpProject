using ConPJ1.DataInMemory;
using ConPJ1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.DBSource
{
    class ProductData : IData<Product>

    {
        static List<Product> _data = new List<Product>() {
            new Product () { ProductID= 101,    ProductName= "Doom",                          Price=250 ,   Quantity =2,    Buyer ="David"},
            new Product () { ProductID= 102,    ProductName= "Tomp Raider",                   Price=200 ,   Quantity =1,    Buyer ="Chris, John"},
            new Product () { ProductID= 103,    ProductName= "Wreckfest - PlayStaion 4",      Price=1060,   Quantity =1,    Buyer ="Chris, John"},
            new Product () { ProductID= 104,    ProductName= "Need for Speed:Rivals",         Price=850 ,   Quantity =10,   Buyer ="David, Maria"},
            new Product () { ProductID= 105,    ProductName= "Dangerous Driving (PS4)",       Price=920 ,   Quantity =5,    Buyer ="Chris, John"},
            new Product () { ProductID= 106,    ProductName= "Team Sonic Racing (PS4)",       Price=350 ,   Quantity =8,    Buyer ="Maria" }

        };

        public Product Add(Product obj)
        {

            obj.ProductID = 1;
            if (_data != null && _data.Count > 0)
                obj.ProductID = _data.Max(a => a.ProductID) + 1;
            _data.Add(obj);
            return obj;


        }

        public Product Get(long id)
        {
            Product cust = _data.Find(p => p.ProductID == id);
            return cust;
        }

        public Product Get(string name)
        {
            Product gets = _data.FirstOrDefault(q => q.ProductName.Contains(name));
            return gets;
        }

        public IEnumerable<Product> GetAll()
        {
            return _data;
        }

         public IEnumerable<Product> GetByName(string name)
        {
            var gets = _data.Where(a => a.ProductName.Contains(name));
            return gets;
        }

        public void LoadSampleData()
        {
            this.Add(new Product { ProductName = "pubg",            Price = 420,    Quantity = 2, Buyer = "Warren" });
            this.Add(new Product { ProductName = "Clash of Clans",  Price = 200,    Quantity = 1, Buyer = "Dann"});
            this.Add(new Product { ProductName = "Clash Royale",    Price = 500,    Quantity = 1, Buyer="Tom" });
            
          
        }

        public Product Name(string name)
        {
            return _data.FirstOrDefault(p => p.ProductName.Contains(name));
        }

        public bool Remove(long id)
        {
            _data.RemoveAll(p => p.ProductID == id);
            return true;
        }
            
        public bool Remove(Product obj)
        {
            _data.RemoveAll(p => p.ProductID == obj.ProductID);
            return true;
        }

        public Product Update(Product obj)
        {
            Product r = _data.FirstOrDefault(q => q.ProductID == obj.ProductID);
            //r.ProductName = obj.ProductName;
            //r.Price = obj.Price;
            //r.Quantity=obj.Quantity;
            //r.Buyer=obj.Buyer;


            if (obj.ProductName != null && obj.ProductName.Trim() != "")
            {
                r.ProductName = obj.ProductName;
            }
            
            else if (obj.Price != null)
            {
                r.Price = obj.Price;
            }
            else if(obj.Quantity !=null)
            {
                r.Quantity = obj.Quantity;
            }
            else if(obj.Buyer !=null)
            {
                r.Buyer = obj.Buyer;
            }
            return r;
        }
        


        // CRUD 

    }
}
