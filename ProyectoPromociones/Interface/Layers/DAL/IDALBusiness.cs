using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALBusiness
    {
        List<Business> GetBusinessByFilter(string pDescripcion);
        Business GetBusinessById(string pId);
        Task<IEnumerable<Business>> GetAllBusiness();
        Task<Business> SaveBusiness(Business pBusiness);
        Task<Business> UpdateBusiness(Business pBusiness);
        Task<bool> DeleteBusiness(string pId);
    }
}
