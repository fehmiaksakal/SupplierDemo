using SupplierDemo.DataAccess.Abstract;
using SupplierDemo.Entites;
using SupplierDemo.Entites.ComplexTypes;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.DataAccess.Concrete
{
    public class EfStockDal : EntityRepositoryBase<Stock, SupplierDbConnection>, IStockDal
    {
        public List<Stocks> GetStocks()
        {
            using (var context = new SupplierDbConnection())
            {
                var result = from st in context.Stock
                             join sp in context.Suppliers on st.SupplierId equals sp.SupplierId
                             join pr in context.Products on st.ProductId equals pr.ProductId
                             select new Stocks
                             {
                                 StockId = st.StockId,
                                 SupplierName = sp.Name,
                                 ProductName = pr.Name,
                                 Quantity = st.Quatity
                             };
                return result.ToList();
            }
        }
    }
}
