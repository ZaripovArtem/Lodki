using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public Production()
        {
            Products = new List<Product>();
        }
    }
}
