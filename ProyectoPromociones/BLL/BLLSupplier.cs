using ProyectoPromociones.DAL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.BLL
{
    public class BLLSupplier : IBLLSupplier
    {
        public List<Supplier> GetSupplierByFilter(string pDescripcion)
        {
            IDALSupplier _DALSupplier = new DALSupplier();
            return _DALSupplier.GetSupplierByFilter(pDescripcion);
        }

        public Supplier GetSupplierById(string pIdSupplier)
        {
            IDALSupplier _DALSupplier = new DALSupplier();
            return _DALSupplier.GetSupplierById(pIdSupplier);
        }


        public Task<IEnumerable<Supplier>> GetAllSupplier()
        {
            IDALSupplier _DALSupplier = new DALSupplier();
            return _DALSupplier.GetAllSupplier();
        }

        public Task<Supplier> SaveSupplier(Supplier pSupplier)
        {
            IDALSupplier _DALSupplier = new DALSupplier();
            Task<Supplier> oSupplier = null;

            if (_DALSupplier.GetSupplierById(pSupplier.IdSupplier.ToString()) == null)
                oSupplier = _DALSupplier.SaveSupplier(pSupplier);
            else
                oSupplier = _DALSupplier.UpdateSupplier(pSupplier);

            return oSupplier;
        }

        public Task<bool> DeleteSupplier(string pId)
        {
            IDALSupplier _DALSupplier = new DALSupplier();

            return _DALSupplier.DeleteSupplier(pId);

        }

        public Task<Supplier> UpdateSupplier(Supplier pSupplier)
        {
            IDALSupplier _DALSupplier = new DALSupplier();
            Task<Supplier> oSupplier = null;

            oSupplier = _DALSupplier.UpdateSupplier(pSupplier);

            return oSupplier;

        }
    }
}
