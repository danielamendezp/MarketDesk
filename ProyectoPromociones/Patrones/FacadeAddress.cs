using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

namespace ProyectoPromociones.Patrones
{
    public class FacadeAddress
    {
        /// <summary>
        /// PROVINCIAS
        /// </summary>
        private List<Provincias> ObtenerProvincia()
        {
            string Ruta = Application.StartupPath + "\\ProvinciasCostaRica\\provincias.json";

            List<Provincias> lista = new List<Provincias>();

            if (File.Exists(Ruta))
            {

                using (StreamReader sr = new StreamReader(Ruta))
                {
                    string datosJson = sr.ReadToEnd();

                    //Crear serializador
                    DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Provincias>));
                    //MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(datosJson));

                    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(datosJson)))
                    {
                        lista = (List<Provincias>)oDataContractJsonSerializer.ReadObject(ms);
                    }

                    return lista;
                }
            }
            return lista;
        }
        /// <summary>
        /// PROVINCIAS
        /// </summary>
        public List<Provincias> GetProvincias()
        {
            return ObtenerProvincia();
        }

        /// <summary>
        /// PROVINCIAS
        /// </summary>
        public Provincias ObtenerProvincia(string IdProvincia)
        {
            Provincias provincia = null;
            List<Provincias> lista=ObtenerProvincia();
            foreach(var item in lista)
            {
                if (item.id == IdProvincia)
                {
                    provincia=item;
                }
            }
            return provincia;
        }
        private List<Cantones> ObtenerCanton()
        {
            string Ruta = Application.StartupPath + "\\ProvinciasCostaRica\\cantones.json";
            List<Cantones> lista = new List<Cantones>();

            if (File.Exists(Ruta))
            {
                using (StreamReader sr = new StreamReader(Ruta))
                {
                    string datosJson = sr.ReadToEnd();

                    // Crear serializador
                     DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Cantones>));

                    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(datosJson)))
                    {
                        lista = (List<Cantones>)oDataContractJsonSerializer.ReadObject(ms);

                    }
                    return lista;
                }
            }
            MessageBox.Show(lista.Count().ToString(), "as", MessageBoxButtons.OK);
            return lista;
        }
        /// <summary>
        /// PROVINCIAS
        /// </summary>
        public Cantones ObtenerCanton(int IdCanton)
        {
            Cantones canton = null;
            List<Cantones> lista = ObtenerCanton();
            foreach (var item in lista)
            {
                if (item.id == IdCanton)
                {
                    canton = item;
                }
            }
            return canton;
        }
        /// <summary>
        /// 
        /// </summary>
        public List<Cantones> ObtenerCantones(int numProvincia)
        {
            List<Cantones> lista = ObtenerCanton();
            List<Cantones> listaRetornar = new List<Cantones>();
            foreach (var item in lista)
            {
                if (item.provincia_id == numProvincia)
                {
                    listaRetornar.Add(item);
                }
            }
            return listaRetornar;
        }
        /// <summary>
        /// 
        /// </summary>
        private List<Distritos> ObtenerDistritos()
        {
            string Ruta = Application.StartupPath + "\\ProvinciasCostaRica\\distritos.json";

            List<Distritos> lista = new List<Distritos>();

            if (File.Exists(Ruta))
            {
                using (StreamReader sr = new StreamReader(Ruta))
                {
                    string datosJson = sr.ReadToEnd();

                    //Crear serializador
                    DataContractJsonSerializer oDataContractJsonSerializer = new DataContractJsonSerializer(typeof(List<Distritos>));
                    //MemoryStream ms = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(datosJson));

                    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(datosJson)))
                    {
                        lista = (List<Distritos>)oDataContractJsonSerializer.ReadObject(ms);

                    }

                    return lista;
                }
            }
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        public List<Distritos> ObtenerDistrito(int numProvincia, int numCanton)
        {
            List<Distritos> lista = ObtenerDistritos();
            List<Distritos> listaRetornar = new List<Distritos>();
            foreach (var item in lista)
            {
                if (item.provincia_id == numProvincia && item.canton_id==numCanton)
                {
                    listaRetornar.Add(item);
                }
            }
            return listaRetornar;
        }
        /// <summary>
        /// 
        /// </summary>
        public Distritos ObtenerDistrito(int IdDistrito)
        {
            Distritos distrito = null;
            List<Distritos> lista = ObtenerDistritos();
            foreach (var item in lista)
            {
                if (item.id == IdDistrito)
                {
                    distrito = item;
                }
            }
            return distrito;
        }
    }
}
