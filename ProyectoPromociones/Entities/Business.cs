using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Business
    {
        public int IdBusiness { get; set; }
        public string LegalID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string BillMessage { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
