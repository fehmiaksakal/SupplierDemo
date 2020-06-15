using SupplierDemo.Business.Abstract;
using SupplierDemo.DataAccess.Abstract;
using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Business.Concrete
{
    public class SupplierManager : ISupplierService
    {

        private ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }
        public Supplier Get(int id)
        {
            return _supplierDal.Get(x => x.SupplierId == id);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetList();
        }
    }
}
