using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.DTO
{
   public class Product : IObject
    {
        public long ProductID { get; set; }        
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Buyer { get; set; }

    }
}
