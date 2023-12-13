using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALPayment
    {
        List<Payment> GetPaymentByFilter(string pDescripcion);
        Payment GetPaymentById(string pId);
        Task<IEnumerable<Payment>> GetAllPayment();
        Task<Payment> SavePayment(Payment pPayment);
        Task<Payment> UpdatePayment(Payment pPayment);
        Task<bool> DeletePayment(string pId);
    }
}
