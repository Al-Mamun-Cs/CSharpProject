using System;

namespace ConPJ1.DTO
{
    public class Product : IObject
    {
        public long ID { get; set; }        
        public string Name { get; set; }
        public double  Price { get; set; }
        public string Buyer { get; set; }
        public int Quantity { get; set; }

    }//c
}//ns
