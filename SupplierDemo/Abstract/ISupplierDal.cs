﻿using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.DataAccess.Abstract
{
    public interface ISupplierDal: IEntityRepository<Supplier>
    {

    }
}
