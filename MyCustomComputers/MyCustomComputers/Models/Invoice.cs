using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCustomComputers.Models;

namespace MyCustomComputers.Models
{
	public class Invoice
	{
	   public int ID {get; set;}
        public ICollection<Order>? Orders { get; set; }
        public string? Name {get; set;}
		public string? Email {get; set;}
		public string? Addres {get; set;}
		public string? City {get; set;}
		public string? State {get; set;} 
		public string? Zip {get; set;} 
		public string? Country {get; set;} 
		public string? Note {get; set;} 
	}
}