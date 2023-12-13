using ProyectoPromociones.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Header
    {
        public int IdHeader { get; set; }

        public DateTime IssueDate { get; set; }
        
        public Business Business { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public bool State { get; set; }

        public override string ToString()
        {
            return "["+IdHeader + "]  "+Customer.ToString() + "    Fecha de emision: " + IssueDate.ToString()+ "    Activa: "+ State;
        }

    }
}
