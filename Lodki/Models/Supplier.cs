using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
        public ICollection<Product> Products { get; set; }
        public Supplier()
        {
            Products = new List<Product>();
        }
    }
}
