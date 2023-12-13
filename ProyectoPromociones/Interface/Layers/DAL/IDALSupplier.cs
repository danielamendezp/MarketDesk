using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALSupplier
    {
        List<Supplier> GetSupplierByFilter(string pDescripcion);
        Supplier GetSupplierById(string pId);
        Task<IEnumerable<Supplier>> GetAllSupplier();
        Task<Supplier> SaveSupplier(Supplier pSupplier);
        Task<Supplier> UpdateSupplier(Supplier pSupplier);
        Task<bool> DeleteSupplier(string pId);
    }
}
