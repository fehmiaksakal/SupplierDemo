using SupplierDemo.Business.Abstract;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SupplierDemo.StockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFStockService" in both code and config file together.
    public class WCFStockService : IWCFStockService
    {
        private IStockService _stockService;

        public WCFStockService(IStockService stockService)
        {
            _stockService = stockService;
        }

        public List<Stock> GetAllStock()
        {
            return _stockService.GetAll();
        }
    }
}
