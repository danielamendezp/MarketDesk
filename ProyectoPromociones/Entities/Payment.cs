using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Payment
    {
        public int IdPayment { get; set; }
        public string PaymentName { get; set; }

        public override string ToString()
        {
            return PaymentName;
        }
    }
}
