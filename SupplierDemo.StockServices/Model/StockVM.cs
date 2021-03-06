﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SupplierDemo.StockServices.Model
{
    [DataContract]
    public class StockVM
    {
        [DataMember]
        public int StockId { get; set; }

        [DataMember]
        public int Quatity { get; set; }

        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public string SupplierId { get; set; }
    }
}