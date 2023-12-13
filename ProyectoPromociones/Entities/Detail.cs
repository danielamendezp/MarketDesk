using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Detail
    {
        public int IdDetail { get; set; }
        public Header Header { get; set; }
        public int ProductQuantity { get; set; }
        public Product Product { get; set; }
       
    }
}
