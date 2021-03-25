using ConPJ1.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ConPJ1.DataInMemory
{
    public class ProductsData : IData<Product>
    {
        static List<Product> data;
           

        public ProductsData()
        {
            if (data == null)
            { 
                data = new List<Product>(); 
                this.LoadSampleData();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return data;
        }

        public Product Get(long id)
        {
            Product res = data.FirstOrDefault(r => r.ID == id);
            return res;
        }
        public Product Get(string name)
        {
            Product res = data.FirstOrDefault(r => r.Name.Contains(name));
            return res;
        }
        public IEnumerable<Product> GetByName(string name)
        {
            IEnumerable<Product> items = data.Where(q => q.Name.Contains(name));
            return items;
        }
        public Product Add(Product newRestaurant)
        {
            newRestaurant.ID = 1;

            if (data != null && data.Count > 0)
                newRestaurant.ID = data.Max(r => r.ID) + 1;

            data.Add(newRestaurant);

            return newRestaurant;
        }
        public bool Remove(long id)
        {
            data.RemoveAll(p => p.ID == id);
            return true;
        }
        public bool Remove(Product res)
        {
            data.RemoveAll(p => p.ID == res.ID);
            return true;
        }
        public Product Update(Product res)
        {
            Product r = data.FirstOrDefault(p => p.ID == res.ID);
            if (res.Name != null && res.Name.Trim() != "") r.Name = res.Name;
            if (res.Quantity != null)  r.Quantity = res.Quantity;
            if (res.Buyer != null && res.Buyer.Trim() != "") r.Buyer = res.Buyer;
            if (res.Price != null) r.Price = res.Price;
            return r;
        }
        public void LoadSampleData()
        {
            this.Add(new Product { ID = 101, Name = "Doom",                      Price = 250, Quantity = 2, Buyer = "David" });
            this.Add(new Product { ID = 102, Name = "Tomp Raider",               Price = 200, Quantity = 1, Buyer = "Chris, John" });
            this.Add(new Product { ID = 103, Name = "Wreckfest - PlayStaion 4",  Price = 1060, Quantity = 1, Buyer = "Chris, John" });
            this.Add(new Product { ID = 104, Name = "Need for Speed:Rivals",     Price = 850, Quantity = 10, Buyer = "David, Maria" });
            this.Add(new Product { ID = 105, Name = "Dangerous Driving (PS4)",   Price = 920, Quantity = 5, Buyer = "Chris, John" });
            this.Add(new Product { ID = 106, Name = "Team Sonic Racing (PS4)",   Price = 350, Quantity = 8, Buyer = "Maria" });
        }

    }//c
}//ns
