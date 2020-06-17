using SupplierDemo.Entites.ComplexTypes;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.DataAccess.Abstract
{
    public interface IStockDal : IEntityRepository<Stock>
    {
        List<Stocks> GetStocks();
        List<Stocks> Update(int stockId, int quantity);
    }
}
