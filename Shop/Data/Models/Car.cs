using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car{

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; } 
        public string Img { get; set; }
        public ushort Price { get; set; }
        public bool IsAvailable { get; set; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
