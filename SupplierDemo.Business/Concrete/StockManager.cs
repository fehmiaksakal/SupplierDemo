using SupplierDemo.Business.Abstract;
using SupplierDemo.DataAccess.Abstract;
using SupplierDemo.Entites.ComplexTypes;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Business.Concrete
{
    public class StockManager : IStockService
    {

        private IStockDal _stockDal;
        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }
        public Stock Get(int id)
        {
            return _stockDal.Get(x => x.StockId == id);
        }

        public List<Stock> GetAll()
        {
            return _stockDal.GetList();
        }

        public List<Stocks> GetStocks()
        {
            return _stockDal.GetStocks();
        }

        public List<Stocks> Update(int stockId, int quantity)
        {
            return _stockDal.Update(stockId, quantity);
        }
    }
}
