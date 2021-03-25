using System;

namespace ConPJ1.DTO
{
    public class Restaurant : IObject
    {
        public long ID { get; set; }        
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Buyer { get; set; }
        

    }//c
}//ns
