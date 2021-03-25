/*using ConPJ1.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ConPJ1.DataInMemory
{
    class RestaurantData : IData<Restaurant>
    {
        static List<Restaurant> _data;

        public RestaurantData()
        {
            if (_data == null)
            {
                _data = new List<Restaurant>();
                this.LoadSampleData();
            }
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _data;
        }

        public Restaurant Get(long id)
        {
            Restaurant res = _data.FirstOrDefault(r => r.ID == id);
            return res;
        }
        public Restaurant Get(string name)
        {
            Restaurant res = _data.FirstOrDefault(r => r.Name.Contains(name));
            return res;
        }
        public IEnumerable<Restaurant> GetByName(string name)
        {
            IEnumerable<Restaurant> items = _data.Where(q => q.Name.Contains(name));
            return items;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            newRestaurant.ID = 1;

            if (_data != null && _data.Count > 0)
                newRestaurant.ID = _data.Max(r => r.ID) + 1;

            _data.Add(newRestaurant);

            return newRestaurant;
        }
        public bool Remove(long id)
        {
            _data.RemoveAll(p => p.ID == id);
            return true;
        }
        public bool Remove(Restaurant res)
        {
            _data.RemoveAll(p => p.ID == res.ID);
            return true;
        }
        public Restaurant Update(Restaurant res)
        {
            Restaurant r = _data.FirstOrDefault(p => p.ID == res.ID);
            if (res.Name != null && res.Name.Trim() != "") r.Name = res.Name;
            if (res.OwnerName != null && res.OwnerName.Trim() != "") r.OwnerName = res.OwnerName;
            if (res.Details != null && res.Details.Trim() != "") r.Details = res.Details;
            if (res.Location != null && res.Location.Trim() != "") r.Location = res.Location;
            if (res.AnnualTurnover > 0) r.AnnualTurnover = res.AnnualTurnover;
            if (res.IsOpen != null ) r.IsOpen = res.IsOpen;
            return r;
        }
        public void LoadSampleData()
        {
            this.Add(new Restaurant { ID = 1, Name = "The House of Kobe", OwnerName="Mr. A", Details ="3 star", Location="", AnnualTurnover=25000000, IsOpen =true });
            this.Add(new Restaurant { ID = 2, Name = "LJ's and the Kat" });
            this.Add(new Restaurant { ID = 3, Name = "King's Contrivance" });
        }

    }//c
}//ns*/
