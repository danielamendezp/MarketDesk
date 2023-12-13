using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALHeader
    {
        List<Header> GetHeaderByFilter(string pDescripcion);
        Header GetHeaderById(string pId);
        Task<IEnumerable<Header>> GetAllHeader();
        Task<Header> SaveHeader(Header pHeader);
        Task<Header> UpdateHeader(Header pHeader);
        Task<bool> DeleteHeader(string pId);
    }
}
