using ProyectoPromociones.Enum;
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Usser
    {
        public int IdUsser { get; set; }
        public string UserName { get; set; }
        public string PersonName { get; set; }
        public string Password { get; set; }
        public EUser ETypeUser { get; set; }
        public Boolean Active { get; set; }
        public DateTime LastLogin { get; set; }

        public override string ToString()
        {
            return UserName;
        }
    }
}
