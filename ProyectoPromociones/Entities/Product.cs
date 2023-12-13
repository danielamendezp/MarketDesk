using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class Product
    {
        public int IdProduct {  get; set; }
        public string CodigoBarras { get; set; }
        public string Name { get; set; }

        public int ExistingQuantity { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public double Cost { get; set; }
        public double ProfitPercentage { get; set; }
        public double Tax {  get; set; }
        public double ListPrice { get; set; }
        
        public Usser User { get; set; }
        public byte[] Photo { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
