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
    public class BLLAddress : IBLLAddress
    {
        public List<Address> GetAddressByFilter(string pDescripcion)
        {
            IDALAddress _DALAddress = new DALAddress();
            return _DALAddress.GetAddressByFilter(pDescripcion);
        }

        public Address GetAddressById(string pIdAddress)
        {
            IDALAddress _DALAddress = new DALAddress();
            return _DALAddress.GetAddressById(pIdAddress);
        }


        public Task<IEnumerable<Address>> GetAllAddress()
        {
            IDALAddress _DALAddress = new DALAddress();
            return _DALAddress.GetAllAddress();
        }

        public Task<Address> SaveAddress(Address pAddress)
        {
            IDALAddress _DALAddress = new DALAddress();
            Task<Address> oAddress = null;

            if (_DALAddress.GetAddressById(pAddress.IdAddress.ToString()) == null)
                oAddress = _DALAddress.SaveAddress(pAddress);
            else
                oAddress = _DALAddress.UpdateAddress(pAddress);

            return oAddress;
        }

        public Task<bool> DeleteAddress(string pId)
        {
            IDALAddress _DALAddress = new DALAddress();

            return _DALAddress.DeleteAddress(pId);

        }

        public Task<Address> UpdateAddress(Address pAddress)
        {
            IDALAddress _DALAddress = new DALAddress();
            Task<Address> oAddress = null;

            oAddress = _DALAddress.UpdateAddress(pAddress);

            return oAddress;

        }

    }
}
