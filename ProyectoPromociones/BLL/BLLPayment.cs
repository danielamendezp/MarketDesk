using ProyectoPromociones.DAL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.BLL
{
    public class BLLPayment : IBLLPayment
    {
        public List<Payment> GetPaymentByFilter(string pDescripcion)
        {
            IDALPayment _DALPayment = new DALPayment();
            return _DALPayment.GetPaymentByFilter(pDescripcion);
        }

        public Payment GetPaymentById(string pIdPayment)
        {
            IDALPayment _DALPayment = new DALPayment();
            return _DALPayment.GetPaymentById(pIdPayment);
        }


        public Task<IEnumerable<Payment>> GetAllPayment()
        {
            IDALPayment _DALPayment = new DALPayment();
            return _DALPayment.GetAllPayment();
        }

        public Task<Payment> SavePayment(Payment pPayment)
        {
            IDALPayment _DALPayment = new DALPayment();
            Task<Payment> oPayment = null;

            if (_DALPayment.GetPaymentById(pPayment.IdPayment.ToString()) == null)
                oPayment = _DALPayment.SavePayment(pPayment);
            else
                oPayment = _DALPayment.UpdatePayment(pPayment);

            return oPayment;
        }

        public Task<bool> DeletePayment(string pId)
        {
            IDALPayment _DALPayment = new DALPayment();

            return _DALPayment.DeletePayment(pId);

        }


        public Task<Payment> UpdatePayment(Payment pPayment)
        {
            IDALPayment _DALPayment = new DALPayment();
            Task<Payment> oPayment = null;

            oPayment = _DALPayment.UpdatePayment(pPayment);

            return oPayment;

        }
    }
}
