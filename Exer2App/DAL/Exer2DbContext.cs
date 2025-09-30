using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Exer2DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Exer2DbContext() : base("name=MyConn")
        {
        }
    }
}
