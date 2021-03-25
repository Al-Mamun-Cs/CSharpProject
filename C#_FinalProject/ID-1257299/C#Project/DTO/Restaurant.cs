using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.DTO
{
    public class Restaurant: IObject
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Location { get; set; }
        public Nullable<bool> IsOpen { get; set; }
    }
}
