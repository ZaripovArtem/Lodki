using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lodki.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlacement { get; set; }
        public DateTime DateExecution { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }
}
