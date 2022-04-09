using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class Client
    {
        public int id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Client()
        {
            Orders = new List<Order>();
        }
    }
}
