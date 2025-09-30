using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class Exer3DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }  // New
        public DbSet<Supplier> Suppliers { get; set; }  // New

        public Exer3DbContext() : base("name=MyConn")
        {
        }
    }
}
