using ProyectoPromociones.BLL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum;
using ProyectoPromociones.Persistencia;
using ProyectoPromociones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using log4net;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProyectoPromociones.UI;
using ProyectoPromociones.Interface;
using System.Net;
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;

namespace ProyectoPromociones.Patrones
{
    public class FactoryMaintenanceDelete
    {/// <summary>
     /// METODOS PARA ELIMINAR EN SQL
     /// </summary>
        public bool DeleteProduct(string id)
        {
            
            BLLProduct bllProduct = new BLLProduct();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllProduct.DeleteProduct(id);
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }

        public bool DeleteCategory(string id)
        {
            
            BLLCategory bllCategory = new BLLCategory();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCategory.DeleteCategory(id); 
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }

        public bool DeletePayment(string id)
        {
            
            BLLPayment bllPaymenty = new BLLPayment();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllPaymenty.DeletePayment(id); 
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }
        public bool DeleteSupplier(string id)
        {
            
            BLLSupplier bllSupplier = new BLLSupplier();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllSupplier.DeleteSupplier(id); 
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }

        public bool DeleteCustomer(string id)
        {
           
            BLLCustomer bllCustomer = new BLLCustomer();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCustomer.DeleteCustomer(id); 
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }

        public bool DeleteUser(Usser user)
        {
                Usser usser = new Usser();
            
                usser.UserName = user.UserName;
                usser.Password = user.Password;
                usser.PersonName = user.PersonName;
                usser.ETypeUser = user.ETypeUser;
                usser.Active = false;
                usser.LastLogin = user.LastLogin;

                BLLUsser bllUsser = new BLLUsser();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    bllUsser.UpdateUsser(usser);
                    MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
                    return true;
                }
                    
            }

        public bool DeleteAddress(string id)
        {
            
            BLLAddress bllAddress = new BLLAddress();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllAddress.DeleteAddress(id); 
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }

        public bool DeleteBusiness(string id)
        {
            
            BLLBusiness bllBusiness = new BLLBusiness();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllBusiness.DeleteBusiness(id); 
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }

        public bool DeletePromotion(string id)
        {

            BLLPromotion bllPromotion = new BLLPromotion();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllPromotion.DeletePromotion(id);
                MessageBox.Show("¡Eliminado!", "Mensaje Informativo");
                return true;
            }
            return false;
        }
    }
}