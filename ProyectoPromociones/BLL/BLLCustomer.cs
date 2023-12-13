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
    public class BLLCustomer : IBLLCustomer
    {
        public List<Customer> GetCustomerByFilter(string pDescripcion)
        {
            IDALCustomer _DALCustomer = new DALCustomer();
            return _DALCustomer.GetCustomerByFilter(pDescripcion);
        }

        public Customer GetCustomerById(string pIdCustomer)
        {
            IDALCustomer _DALCustomer = new DALCustomer();
            return _DALCustomer.GetCustomerById(pIdCustomer);
        }


        public Task<IEnumerable<Customer>> GetAllCustomer()
        {
            IDALCustomer _DALCustomer = new DALCustomer();
            return _DALCustomer.GetAllCustomer();
        }

        public Task<Customer> SaveCustomer(Customer pCustomer)
        {
            IDALCustomer _DALCustomer = new DALCustomer();
            Task<Customer> oCustomer = null;

            if (_DALCustomer.GetCustomerById(pCustomer.IdCustomer.ToString()) == null)
                oCustomer = _DALCustomer.SaveCustomer(pCustomer);
            else
                oCustomer = _DALCustomer.UpdateCustomer(pCustomer);

            return oCustomer;
        }

        public Task<bool> DeleteCustomer(string pId)
        {
            IDALCustomer _DALCustomer = new DALCustomer();

            return _DALCustomer.DeleteCustomer(pId);

        }

        public Task<Customer> UpdateCustomer(Customer pCustomer)
        {
            IDALCustomer _DALCustomer = new DALCustomer();
            Task<Customer> oCustomer = null;

            oCustomer = _DALCustomer.UpdateCustomer(pCustomer);

            return oCustomer;

        }
    }
}
