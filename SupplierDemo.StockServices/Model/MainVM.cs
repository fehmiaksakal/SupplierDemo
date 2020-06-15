using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SupplierDemo.StockServices.Model
{
    public class MainVM
    {
        public List<StockVM> Stock { get; set; }
        public List<SupplierVM> Supp{ get; set; }

    }
}