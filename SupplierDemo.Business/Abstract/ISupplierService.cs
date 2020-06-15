using SupplierDemo.Entites.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierDemo.Business.Abstract
{
    public interface ISupplierService
    {
        Supplier Get(int id);
        List<Supplier> GetAll();
    }
}
