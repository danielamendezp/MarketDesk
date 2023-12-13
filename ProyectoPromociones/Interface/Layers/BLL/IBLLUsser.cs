using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLUsser
    {

        List<Usser> GetUsserByFilter(string pDescripcion);
        Usser GetUsserById(string pIdUsser);
        Task<IEnumerable<Usser>> GetAllUsser();
        Task<Usser> SaveUsser(Usser pUsser);
        Task<bool> DeleteUsser(string pId);
    }
}
