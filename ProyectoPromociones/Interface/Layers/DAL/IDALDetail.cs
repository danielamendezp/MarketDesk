using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALDetail
    {
        List<Detail> GetDetailByFilter(string pDescripcion);
        Detail GetDetailById(string pId);
        Task<IEnumerable<Detail>> GetAllDetail();
        Task<Detail> SaveDetail(Detail pDetail);
        Task<Detail> UpdateDetail(Detail pDetail);
        Task<bool> DeleteDetail(string pId);
    }
}
