using Ninject.Modules;
using SupplierDemo.Business.Abstract;
using SupplierDemo.Business.Concrete;
using SupplierDemo.DataAccess.Abstract;
using SupplierDemo.DataAccess.Concrete;
using SupplierDemo.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Business.DependencyResolves.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IStockService>().To<StockManager>().InSingletonScope();
            Bind<IStockDal>().To<EfStockDal>();
            Bind<DbContext>().To<SupplierDbConnection>();
        }

    }
}
