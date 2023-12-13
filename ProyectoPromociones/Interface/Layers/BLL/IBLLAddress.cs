using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLAddress
    {
        List<Address> GetAddressByFilter(string pDescripcion);
        Address GetAddressById(string pIdAddress);
        Task<IEnumerable<Address>> GetAllAddress();
        Task<Address> SaveAddress(Address pAddress);
        Task<bool> DeleteAddress(string pId);
    }
}
