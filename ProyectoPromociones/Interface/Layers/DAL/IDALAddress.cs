using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALAddress
    {
        List<Address> GetAddressByFilter(string pDescripcion);
        Address GetAddressById(string pId);
        Task<IEnumerable<Address>> GetAllAddress();
        Task<Address> SaveAddress(Address pAddress);
        Task<Address> UpdateAddress(Address pAddress);
        Task<bool> DeleteAddress(string pId);
    }
}
