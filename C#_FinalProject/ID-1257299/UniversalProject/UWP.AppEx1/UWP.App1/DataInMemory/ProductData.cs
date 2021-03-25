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
        static List<Product> _data; 
        //= new List<Product>(){
        //   new Product () { ID= 101,    Name= "Doom",                          Price=250 ,   Quantity =2,    Buyer ="David"},
        //   new Product () { ID= 102,    Name= "Tomp Raider",                   Price=200 ,   Quantity =1,    Buyer ="Chris, John"},
        //   new Product () { ID= 103,    Name= "Wreckfest - PlayStaion 4",      Price=1060,   Quantity =5,    Buyer ="Chris"},
        //   new Product () { ID= 104,    Name= "Need for Speed:Rivals",         Price=850 ,   Quantity =10,   Buyer ="David, Maria"},
        //   new Product () { ID= 105,    Name= "Dangerous Driving (PS4)",       Price=920 ,   Quantity =5,    Buyer ="Chris, John"},
        //   new Product () { ID= 106,    Name= "Team Sonic Racing (PS4)",       Price=350 ,   Quantity =8,    Buyer ="Maria" }

        //};

        public Product Add(Product obj)
        {

            obj.ID = 1;
            if (_data != null && _data.Count > 0)
                obj.ID = _data.Max(a => a.ID) + 1;
            _data.Add(obj);
            return obj;


        }

        public Product Get(long id)
        {
            Product cust = _data.Find(p => p.ID == id);
            return cust;
        }

        public Product Get(string name)
        {
            Product gets = _data.FirstOrDefault(q => q.Name.Contains(name));
            return gets;
        }

        public IEnumerable<Product> GetAll()
        {
            return _data;
        }

         public IEnumerable<Product> GetByName(string name)
        {
            var gets = _data.Where(a => a.Name.Contains(name));
            return gets;
        }

        public void LoadSampleData()
        {
            this.Add(new Product { Name = "pubg",            Price = 420,    Quantity = 2, Buyer = "Warren" });
            this.Add(new Product { Name = "Clash of Clans",  Price = 200,    Quantity = 1, Buyer = "Dann"});
            this.Add(new Product { Name = "Clash Royale",    Price = 500,    Quantity = 1, Buyer="Tom" });
            
          
        }

        public Product Name(string name)
        {
            return _data.FirstOrDefault(p => p.Name.Contains(name));
        }

        public bool Remove(long id)
        {
            _data.RemoveAll(p => p.ID == id);
            return true;
        }
            
        public bool Remove(Product obj)
        {
            _data.RemoveAll(p => p.ID == obj.ID);
            return true;
        }

        public Product Update(Product obj)
        {
            Product r = _data.FirstOrDefault(q => q.ID == obj.ID);
            //r.ProductName = obj.ProductName;
            //r.Price = obj.Price;
            //r.Quantity=obj.Quantity;
            //r.Buyer=obj.Buyer;


            if (obj.Name != null && obj.Name.Trim() != "")
            {
                r.Name = obj.Name;
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
