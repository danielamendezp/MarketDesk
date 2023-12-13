using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Invoice
    {
        public Header Header { get; set; }
        public List<Detail> details { get; set; }
    }
}
