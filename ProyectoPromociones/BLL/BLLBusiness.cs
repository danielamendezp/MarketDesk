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
    public class BLLBusiness : IBLLBusiness
    {
        public List<Business> GetBusinessByFilter(string pDescripcion)
        {
            IDALBusiness _DALBusiness = new DALBusiness();
            return _DALBusiness.GetBusinessByFilter(pDescripcion);
        }

        public Business GetBusinessById(string pIdBusiness)
        {
            IDALBusiness _DALBusiness = new DALBusiness();
            return _DALBusiness.GetBusinessById(pIdBusiness);
        }


        public Task<IEnumerable<Business>> GetAllBusiness()
        {
            IDALBusiness _DALBusiness = new DALBusiness();
            return _DALBusiness.GetAllBusiness();
        }

        public Task<Business> SaveBusiness(Business pBusiness)
        {
            IDALBusiness _DALBusiness = new DALBusiness();
            Task<Business> oBusiness = null;

            if (_DALBusiness.GetBusinessById(pBusiness.IdBusiness.ToString()) == null)
                oBusiness = _DALBusiness.SaveBusiness(pBusiness);
            else
                oBusiness = _DALBusiness.UpdateBusiness(pBusiness);

            return oBusiness;
        }

        public Task<bool> DeleteBusiness(string pId)
        {
            IDALBusiness _DALBusiness = new DALBusiness();

            return _DALBusiness.DeleteBusiness(pId);

        }
        public Task<Business> UpdateBusiness(Business pBusiness)
        {
            IDALBusiness _DALBusiness = new DALBusiness();
            Task<Business> oBusiness = null;

                oBusiness = _DALBusiness.UpdateBusiness(pBusiness);

            return oBusiness;

        }
    }
}
