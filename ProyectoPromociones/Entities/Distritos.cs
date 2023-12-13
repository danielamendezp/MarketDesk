using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProyectoPromociones.Entities
{
    public class Distritos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string distrito { get; set; }
        public string coordenadas { get; set; }
        public int provincia_id { get; set; }
        public int canton_id { get; set; }

        public override string ToString()
        {
            return distrito;
        }
    }
}
