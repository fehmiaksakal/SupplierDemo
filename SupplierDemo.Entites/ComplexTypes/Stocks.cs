using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Entites.ComplexTypes
{
    public class Stocks
    {
        public int StockId { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
