using SupplierDemo.StockServices.Model;
using System.Collections.Generic;

namespace SupplierDemo.WebUI
{
    public class HomePageVM
    {
        public List<StockVM> stocks { get; set; }
        public List<SupplierVM> suppliers { get; set; }
    }
}