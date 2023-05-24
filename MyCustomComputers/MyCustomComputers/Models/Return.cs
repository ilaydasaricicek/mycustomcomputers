using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCustomComputers.Models;

namespace MyCustomComputers.Models
{
    public class Return
    {
        public int ID { get; set; }
        public User? User { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public string? Reason { get; set; }
        public string? Note { get; set; }
        public string? Status { get; set; }
    }
}