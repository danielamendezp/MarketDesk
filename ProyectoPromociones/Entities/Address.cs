using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Address
    {
        public int IdAddress { get; set; }
        public Provincias Provincia { get; set; }
        public Cantones Canton { get; set; }
     
        public Distritos Distrito { get; set; }
        public string Description { get; set; }

    } 
}
