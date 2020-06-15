using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SupplierDemo.StockServices.Model
{
    [DataContract]
    public class SupplierVM
    {
        [DataMember]
        public int SupplierId { get; set; }
        [DataMember]
        public string SupplierName { get; set; }
    }
}