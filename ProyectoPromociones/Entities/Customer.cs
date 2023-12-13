using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones
{
    public class Customer
    {
        public int IdCustomer { get; set; }

        public string Identification { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public DateTime Birth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public byte[] Photo { get ; set; }

        public override string ToString()
        {
            return Name + " - "+Identification;
        }
    }
}
