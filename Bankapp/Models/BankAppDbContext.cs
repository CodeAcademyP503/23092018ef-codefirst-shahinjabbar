using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankapp.Models
{
    public class BankAppDbContext : DbContext
    {
        public BankAppDbContext() : base("mydb") { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Credit> Credits { get; set; }

    }
}
