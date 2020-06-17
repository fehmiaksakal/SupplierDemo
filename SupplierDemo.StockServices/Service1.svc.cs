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
        private ISupplierService _supplierService;

        public Service1(IStockService stockService, ISupplierService supplierService)
        {
            _stockService = stockService;
            _supplierService = supplierService;
        }

        public List<StockVM> GetOnlyStock()
        {
            List<StockVM> stockvm = new List<StockVM>();
            var stk = _stockService.GetStocks();
            foreach (var item in stk)
            {
                StockVM stockVM = new StockVM()
                {
                    StockId = item.StockId,
                    ProductId = item.ProductName,
                    SupplierId = item.SupplierName,
                    Quatity = item.Quantity,
                };
                stockvm.Add(stockVM);
            }
            return stockvm;
        }

        public MainVM GetStocks()
        {

            List<StockVM> stockvm = new List<StockVM>();
            var stk = _stockService.GetStocks();
            foreach (var item in stk)
            {
                StockVM stockVM = new StockVM()
                {
                    StockId = item.StockId,
                    ProductId = item.ProductName,
                    SupplierId = item.SupplierName,
                    Quatity = item.Quantity,
                };
                stockvm.Add(stockVM);
            }
            List<SupplierVM> suppliers = new List<SupplierVM>();
            var sup = _supplierService.GetAll();
            foreach (var item in sup)
            {
                SupplierVM supkVM = new SupplierVM()
                {
                    SupplierId = item.SupplierId,
                    SupplierName = item.Name
                };
                suppliers.Add(supkVM);
            }

            MainVM mainVM = new MainVM()
            {
                Stock = stockvm,
                Supp = suppliers
            };

            return mainVM;
        }

        public List<StockVM> UpdateStock(int stockId, int quantity)
        {
            List<StockVM> stockvm = new List<StockVM>();
            var stk = _stockService.Update(stockId, quantity);
            foreach (var item in stk)
            {
                StockVM stockVM = new StockVM()
                {
                    StockId = item.StockId,
                    ProductId = item.ProductName,
                    SupplierId = item.SupplierName,
                    Quatity = item.Quantity,
                };
                stockvm.Add(stockVM);
            }
            return stockvm;
        }
    }
}
