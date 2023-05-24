using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCustomComputers.Models;

namespace MyCustomComputers.Data
{
    public class MyCustomComputersContext : DbContext
    {
        public MyCustomComputersContext (DbContextOptions<MyCustomComputersContext> options)
            : base(options)
        {
        }

        public DbSet<MyCustomComputers.Models.Product>? Product { get; set; } = default!;
        public DbSet<MyCustomComputers.Models.Invoice>? Invoice { get; set; } = default!;
        public DbSet<MyCustomComputers.Models.Order>? Order { get; set; } = default!;
        public DbSet<MyCustomComputers.Models.Return>? Return { get; set; } = default!;
        public DbSet<MyCustomComputers.Models.User>? User { get; set; } = default!;
    }
}
