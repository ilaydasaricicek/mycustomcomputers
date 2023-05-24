using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCustomComputers.Models;

namespace MyCustomComputers.Models
{
	public class Product
	{
		public int ID {get; set;}
        public ICollection<Order>? Orders { get; set; }
        public string? Title {get; set;}
		public string? Brand {get; set;}
		public string? Model {get; set;}
		public string? ScreenSize {get; set;}
		public string? CPU {get; set;}
		public string? RAM {get; set;}
		public string? HardDisc {get; set;}
		public string? Graphics {get; set;}
        public string? imageUrl { get; set; }
        public string? Price { get; set; }
        public int Stock {get; set;}
	}
}