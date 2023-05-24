using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
﻿using System.ComponentModel.DataAnnotations;
using MyCustomComputers.Models;

namespace MyCustomComputers.Models
{
	public class Order
	{
		public int ID {get; set;}
        public User? User { get; set; }
        public Return? Return { get; set; }
        public Product? Product { get; set; }
        public Invoice? Invoice { get; set; }
        public int Price {get; set;}
		public int VAT {get; set;}
		public int TotalPrice {get; set;}
		public int ShippingFee {get; set;}
		public string? Addres {get; set;}
		public string? ShippingMethod {get; set;}
		public string? OrderStatus {get; set;}
	}
}