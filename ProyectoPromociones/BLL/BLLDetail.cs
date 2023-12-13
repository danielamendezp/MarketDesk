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
    public class BLLDetail : IBLLDetail
    {
        public List<Detail> GetDetailByFilter(string pDescripcion)
        {
            IDALDetail _DALDetail = new DALDetail();
            return _DALDetail.GetDetailByFilter(pDescripcion);
        }

        public Detail GetDetailById(string pIdDetail)
        {
            IDALDetail _DALDetail = new DALDetail();
            return _DALDetail.GetDetailById(pIdDetail);
        }


        public Task<IEnumerable<Detail>> GetAllDetail()
        {
            IDALDetail _DALDetail = new DALDetail();
            return _DALDetail.GetAllDetail();
        }

        public Task<Detail> SaveDetail(Detail pDetail)
        {
            IDALDetail _DALDetail = new DALDetail();
            Task<Detail> oDetail = null;

            if (_DALDetail.GetDetailById(pDetail.IdDetail.ToString()) == null)
                oDetail = _DALDetail.SaveDetail(pDetail);
            else
                oDetail = _DALDetail.UpdateDetail(pDetail);

            return oDetail;
        }
        public Task<bool> DeleteDetail(string pId)
        {
            IDALDetail _DALDetail = new DALDetail();

            return _DALDetail.DeleteDetail(pId);

        }

        public Task<Detail> UpdateDetail(Detail pDetail)
        {
            IDALDetail _DALDetail = new DALDetail();
            Task<Detail> oDetail = null;

            oDetail = _DALDetail.UpdateDetail(pDetail);

            return oDetail;

        }
    }
}
