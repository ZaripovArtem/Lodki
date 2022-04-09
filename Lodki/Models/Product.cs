using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public int Price { get; set; }
        public Production Production { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Product()
        {
            Orders = new List<Order>();
        }
    }
}
