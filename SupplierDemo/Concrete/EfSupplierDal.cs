using SupplierDemo.DataAccess.Abstract;
using SupplierDemo.Entites;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.DataAccess.Concrete
{
   public class EfSupplierDal : EntityRepositoryBase<Supplier,SupplierDbConnection> , ISupplierDal
    {

    }
}
