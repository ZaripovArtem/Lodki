using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Employee()
        {
            Orders = new List<Order>();
        }
    }
}
