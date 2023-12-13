using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Entities
{
    public class ServiceBCCR
    {
        //Agregar los credenciales para el uso del consumo API del Dolar BCCR
        private readonly string TOKEN = "MGOAOMNNCP";
        private readonly string NOMBRE = "Daniela Mendez";
        private readonly string CORREO = "mendez.daniela1199@gmail.com";
        public IEnumerable<Dolar> GetDolar(DateTime pFechaInicial, DateTime pFechaFinal, String pCompraoVenta)
        {
            //Se crean las variables a utilizar
            List<Dolar> lista = new List<Dolar>();
            DataSet dataset = null;
            string fecha_inicial, fecha_final;
            string tipoCompraoVenta;
            // Se convierten las fechas a string en el formato solicitado
            fecha_inicial = pFechaInicial.ToString("dd/MM/yyyy");
            fecha_final = pFechaFinal.ToString("dd/MM/yyyy");
            // Se compara si es compra (317) o venta (318)
            tipoCompraoVenta = pCompraoVenta.Equals("c", StringComparison.InvariantCulture) ? "317" : "318";

            // Protocolo de comunicaciones
            System.Net.ServicePointManager.SecurityProtocol =
            System.Net.SecurityProtocolType.Tls12;
            // Se instancia al Servicio Web
            BCCR.wsindicadoreseconomicosSoapClient client =
            new
            BCCR.wsindicadoreseconomicosSoapClient("wsindicadoreseconomicosSoap12");
            // Se invoca.
            dataset = client.ObtenerIndicadoresEconomicos(tipoCompraoVenta, fecha_inicial, fecha_final, NOMBRE, "N", CORREO, TOKEN);
            //Se carga el taset
            DataTable table = dataset.Tables[0];
            //Se recorre el dataset
            foreach (DataRow row in table.Rows)
            {
                // Validar el error. No es la forma correcta pero bueno.
                if (row[0].ToString().Contains("error"))
                {
                    throw new Exception(row[0].ToString());
                }
                //Se asignan lso valores a la clase de tipo dolar
                Dolar dolar = new Dolar();
                dolar.Codigo = row[0].ToString();
                dolar.Fecha = DateTime.Parse(row[1].ToString());
                dolar.Monto = Convert.ToDouble(row[2].ToString());
                lista.Add(dolar);
            }
            //Se retorna la lista
            return lista;
        }
    }
}
