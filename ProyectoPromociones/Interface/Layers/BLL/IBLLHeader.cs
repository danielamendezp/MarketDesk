using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLHeader
    {

        List<Header> GetHeaderByFilter(string pDescripcion);
        Header GetHeaderById(string pIdHeader);
        Task<IEnumerable<Header>> GetAllHeader();
        Task<Header> SaveHeader(Header pHeader);
        Task<bool> DeleteHeader(string pId);
    }
}
