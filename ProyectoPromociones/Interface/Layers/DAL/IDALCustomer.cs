using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALCustomer
    {
        List<Customer> GetCustomerByFilter(string pDescripcion);
        Customer GetCustomerById(string pId);
        Task<IEnumerable<Customer>> GetAllCustomer();
        Task<Customer> SaveCustomer(Customer pCustomer);
        Task<Customer> UpdateCustomer(Customer pCustomer);
        Task<bool> DeleteCustomer(string pId);
    }
}
