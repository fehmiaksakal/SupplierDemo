using SupplierDemo.Business.Abstract;
using SupplierDemo.Entites.Entities;
using SupplierDemo.StockServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SupplierDemo.StockServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private IStockService _stockService;
        private ISupplierService _supplierService;//, ISupplierService supplierService

        public Service1(IStockService stockService)
        {
            _stockService = stockService;
           // _supplierService = supplierService;
        }
        public MainVM GetStocks()
        {
               
                List<StockVM> stockvm = new List<StockVM>();
                var stk = _stockService.GetAll();
                foreach (var item in stk)
                {
                    StockVM stockVM = new StockVM()
                    {
                        ProductId = item.ProductId,
                        Quatity = item.Quatity,
                        StockId = item.StockId,
                        SupplierId = item.SupplierId
                    };
                    stockvm.Add(stockVM);
                }
                //List<SupplierVM> suppliers = new List<SupplierVM>();
                //var sup = _supplierService.GetAll();
                //foreach (var item in sup)
                //{
                //    SupplierVM supkVM = new SupplierVM()
                //    {
                //        SupplierId = item.SupplierId,
                //        SupplierName = item.Name
                //    };
                //    suppliers.Add(supkVM);
                //}

            MainVM mainVM = new MainVM()
            {
                Stock = stockvm,
               // Supp = suppliers
            };

            return mainVM;
        }
    }
}
