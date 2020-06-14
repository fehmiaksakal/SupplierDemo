using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SupplierDemo.StockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFStockService" in both code and config file together.
    [ServiceContract]
    public interface IWCFStockService
    {
        [OperationContract]
        string Get();
        //List<Stock> GetAllStock();
    }
}
