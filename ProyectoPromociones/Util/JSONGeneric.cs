using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Util
{
    public class JSONGeneric<T>
    {

        /// <summary>
        /// Convierte una string de datos en un Objeto de tipo JSON
        /// </summary>
        /// <param name="pDatos"></param>
        /// <returns>List<T></returns>
        public static T JSonToObject(string pDatos)
        {

            //Crear serializador
            DataContractJsonSerializer oDataContractJsonSerializer
                = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms
                = new MemoryStream(System.Text.ASCIIEncoding.UTF8.GetBytes(pDatos));


            // Convertirlo en Objetos
            T @object = (T)oDataContractJsonSerializer.ReadObject(ms);

            return @object;

        }

        /// <summary>
        /// Convierte un objeto en formato List en una string en formato JSOn
        /// </summary>
        /// <param name="pObject">debe ser un List</param>
        /// <returns>string</returns>
        public static string ObjectToJson(T pObject)
        {

            string datosJson = "";
            MemoryStream ms = new MemoryStream();

            DataContractJsonSerializer oDataContractJsonSerializer
                = new DataContractJsonSerializer(typeof(T));

            oDataContractJsonSerializer.WriteObject(ms, pObject);
            datosJson = Encoding.Default.GetString(ms.ToArray());

            return datosJson;


        }


    }
}
