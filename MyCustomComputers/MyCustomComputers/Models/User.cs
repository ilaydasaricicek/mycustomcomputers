using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCustomComputers.Models;

namespace MyCustomComputers.Models
{
	public class User
	{
		public int ID {get; set;}
		public string? FirstName {get; set;}
		public string? LastName {get; set;}
		public string? Password {get; set;}
		public string? Email {get; set;}
		public string? Status {get; set;}
		public ICollection<Order>? Orders { get; set;}
        public ICollection<Return>? Returns { get; set; }
        public DateTime CreatedOn {get; set;}
	}
}