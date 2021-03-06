﻿using SupplierDemo.Entites.ComplexTypes;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Business.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAll();
        Stock Get(int id);

        List<Stocks> GetStocks();
        List<Stocks> Update(int stockId, int quantity);
    }
}
