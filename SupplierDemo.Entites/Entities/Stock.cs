using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Entites.Entities
{
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public int Quatity { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Suppliers { get; set; }
    }
}
