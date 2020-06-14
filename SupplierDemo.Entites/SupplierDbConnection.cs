using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Entites
{
    public class SupplierDbConnection : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public SupplierDbConnection() : base("SupplierConnection")
        {

        }
    }
}
