using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Patrones
{
    public class InvoicePersistencia 

    {
        public static List<Product> products { get; set; } = new List<Product>();
        public static List<int> cantidades { get; set; } = new List<int>();
        public static List<Promotion> promotions { get; set; } = new List<Promotion>();
        public static double descuento { get; set; }

        public static string correo { get; set; } 
        public static void listaCantidades(int cantidad)
        {
            cantidades.Add(cantidad);

        }

        public static void listProduct(Product product)
        {
            products.Add(product);
        }

        public static double subTotal()
        {
            double vsubtotal = 0;
            int i = 0;
            foreach (Product product in products)
            {
                vsubtotal += product.ListPrice * cantidades[i];
                i++;
            }
            return vsubtotal;
        }

        public static double taxes()
        {
            double vtaxes = 0;
            int i = 0;
            foreach (Product product in products)
            {
                vtaxes += (product.ListPrice*product.Tax )* cantidades[i];
                i++;
            }
            return vtaxes;
        }

        public static double total()
        {
            double total= subTotal()-descuento;
            return total;
        }
    }
}
