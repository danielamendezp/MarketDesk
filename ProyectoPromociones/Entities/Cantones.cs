using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Cantones
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string canton { get; set; }
        public string coordenadas { get; set; }
        public int provincia_id { get; set; }

        public override string ToString()
        {
            return canton;
        }


    }
}
