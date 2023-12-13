using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProyectoPromociones.Entities
{
    public class Provincias
    {
        public string id { get; set; }
        public string codigo { get; set; }
        public string provincia { get; set; }
        public string coordenadas { get; set; }

        public override string ToString()
        {
            return provincia;
        }
    }
}
