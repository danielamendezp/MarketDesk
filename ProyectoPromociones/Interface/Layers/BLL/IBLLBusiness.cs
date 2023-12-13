using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLBusiness
    {

        List<Business> GetBusinessByFilter(string pDescripcion);
        Business GetBusinessById(string pIdBusiness);
        Task<IEnumerable<Business>> GetAllBusiness();
        Task<Business> SaveBusiness(Business pBusiness);
        Task<bool> DeleteBusiness(string pId);
    }
}
