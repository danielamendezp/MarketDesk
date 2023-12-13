using log4net;
using ProyectoPromociones.BLL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.Persistencia;
using ProyectoPromociones.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.DAL
{
    public class DALCustomer : IDALCustomer
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteCustomer(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Customer Where (IdCustomer = @IdCustomer) ";

                command.Parameters.AddWithValue("@IdCustomer", pId);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    retorno = true;

                return retorno;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new Util.CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomerX()
        {

            List<Customer> lista = new List<Customer>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Customer WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        BLLAddress bLLAddress=new BLLAddress();
                        // Mapearlas
                        Customer oCustomer = new Customer();
                        oCustomer.IdCustomer = (int)reader["IdCustomer"];
                        oCustomer.Identification = reader["Identification"].ToString();
                        oCustomer.Name = reader["Name"].ToString();
                        oCustomer.Address = (Address)bLLAddress.GetAddressById(reader["IdAddress"].ToString());
                        oCustomer.Nationality = reader["Nationality"].ToString();
                        oCustomer.Gender = reader["Gender"].ToString();
                        oCustomer.Birth = DateTime.Parse(reader["Birth"].ToString());
                        oCustomer.PhoneNumber = reader["PhoneNumber"].ToString();
                        oCustomer.Email = reader["Email"].ToString();
                        oCustomer.Photo = (byte[])reader["Photo"];
                        lista.Add(oCustomer);
                    }


                }
                return lista;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            DataSet ds = null;
            List<Customer> lista = new List<Customer>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Customer";
                //command.Parameters.AddWithValue("@IdCustomer", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BLLAddress bLLAddress = new BLLAddress();
                        // Mapearlas
                        Customer oCustomer = new Customer();
                        oCustomer.IdCustomer = (int)dr["IdCustomer"];
                        oCustomer.Identification = dr["Identification"].ToString();
                        oCustomer.Name = dr["Name"].ToString();
                        oCustomer.Address = (Address)bLLAddress.GetAddressById(dr["IdAddress"].ToString());
                        oCustomer.Nationality = dr["Nationality"].ToString();
                        oCustomer.Gender = dr["Gender"].ToString();
                        oCustomer.Birth = DateTime.Parse(dr["Birth"].ToString());
                        oCustomer.PhoneNumber = dr["PhoneNumber"].ToString();
                        oCustomer.Email = dr["Email"].ToString();
                        oCustomer.Photo = (byte[])dr["Photo"];

                        lista.Add(oCustomer);
                    }
                }

                return lista;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }

        public List<Customer> GetCustomerByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Customer> lista = new List<Customer>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Customer";
                command.Parameters.AddWithValue("@filtro", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BLLAddress bLLAddress = new BLLAddress();
                        // Mapearlas
                        Customer oCustomer = new Customer();
                        oCustomer.IdCustomer = (int)dr["IdCustomer"];
                        oCustomer.Identification = dr["Identification"].ToString();
                        oCustomer.Name = dr["Name"].ToString();
                        oCustomer.Address = (Address)bLLAddress.GetAddressById(dr["IdAddress"].ToString());
                        oCustomer.Nationality = dr["Nationality"].ToString();
                        oCustomer.Gender = dr["Gender"].ToString();
                        oCustomer.Birth = DateTime.Parse(dr["Birth"].ToString());
                        oCustomer.PhoneNumber = dr["PhoneNumber"].ToString();
                        oCustomer.Email = dr["Email"].ToString();
                        oCustomer.Photo = (byte[])dr["Photo"];

                        lista.Add(oCustomer);
                    }
                }

                return lista;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }

        public Customer GetCustomerById(string pIdCustomer)
        {
            DataSet ds = null;
            Customer oCustomer = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Customer Where IdCustomer = @IdCustomer ";
                command.Parameters.AddWithValue("@IdCustomer", pIdCustomer);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oCustomer = new Customer();
                        BLLAddress bLLAddress = new BLLAddress();
                        // Mapearlas
                        oCustomer.IdCustomer = (int)dr["IdCustomer"];
                        oCustomer.Identification = dr["Identification"].ToString();
                        oCustomer.Name = dr["Name"].ToString();
                        oCustomer.Address = (Address)bLLAddress.GetAddressById(dr["IdAddress"].ToString());
                        oCustomer.Nationality = dr["Nationality"].ToString();
                        oCustomer.Gender = dr["Gender"].ToString();
                        oCustomer.Birth = DateTime.Parse(dr["Birth"].ToString());
                        oCustomer.PhoneNumber = dr["PhoneNumber"].ToString();
                        oCustomer.Email = dr["Email"].ToString();
                        oCustomer.Photo = (byte[])dr["Photo"];
                    }
                }

                return oCustomer;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }


        public async Task<Customer> SaveCustomer(Customer pCustomer)
        {
            Customer oCustomer = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Customer(Identification, Name, IdAddress, Nationality, Gender, Birth, PhoneNumber, Email, Photo)
                   VALUES (@Identification, @Name, @IdAddress, @Nationality, @Gender, @Birth, @PhoneNumber, @Email, @Photo)";

            try
            {
                //command.Parameters.AddWithValue("@IdCustomer", pCustomer.IdCustomer);
                command.Parameters.AddWithValue("@Identification", pCustomer.Identification);
                command.Parameters.AddWithValue("@Name", pCustomer.Name);
                command.Parameters.AddWithValue("@IdAddress", pCustomer.Address.IdAddress);
                command.Parameters.AddWithValue("@Nationality", pCustomer.Nationality);
                command.Parameters.AddWithValue("@Gender", pCustomer.Gender);
                command.Parameters.AddWithValue("@Birth", pCustomer.Birth);
                command.Parameters.AddWithValue("@PhoneNumber", pCustomer.PhoneNumber);
                command.Parameters.AddWithValue("@Email", pCustomer.Email);
                command.Parameters.AddWithValue("@Photo", pCustomer.Photo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oCustomer = this.GetCustomerById(pCustomer.IdCustomer.ToString());
                }

                return oCustomer;

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }

        public async Task<Customer> UpdateCustomer(Customer pCustomer)
        {

            string sql = @"UPDATE Customer 
                   SET Identification = @Identification, 
                       Name = @Name, 
                       IdAddress = @IdAddress, 
                       Nationality = @Nationality,
                       Gender = @Gender, 
                       Birth = @Birth, 
                       PhoneNumber = @PhoneNumber, 
                       Email = @Email, 
                       Photo = @Photo
                   WHERE (IdCustomer = @IdCustomer)";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Customer oCustomer = new Customer();
            try
            {
                command.Parameters.AddWithValue("@IdCustomer", pCustomer.IdCustomer);
                command.Parameters.AddWithValue("@Identification", pCustomer.Identification);
                command.Parameters.AddWithValue("@Name", pCustomer.Name);
                command.Parameters.AddWithValue("@IdAddress", pCustomer.Address.IdAddress);
                command.Parameters.AddWithValue("@Nationality", pCustomer.Nationality);
                command.Parameters.AddWithValue("@Gender", pCustomer.Gender);
                command.Parameters.AddWithValue("@Birth", pCustomer.Birth);
                command.Parameters.AddWithValue("@PhoneNumber", pCustomer.PhoneNumber);
                command.Parameters.AddWithValue("@Email", pCustomer.Email);
                command.Parameters.AddWithValue("@Photo", pCustomer.Photo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCustomer = this.GetCustomerById(pCustomer.IdCustomer.ToString());

                return oCustomer;

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                if (er is SqlException)
                {
                    msg.AppendFormat("{0}\n", UtilError.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), command, er as SqlException));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw new CustomException(UtilError.GetCustomErrorByNumber(er as SqlException));
                }
                else
                {
                    msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                    _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                    throw;
                }
            }
        }
    }
}
