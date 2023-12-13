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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.DAL
{
    public class DALBusiness : IDALBusiness
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteBusiness(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Business Where (IdBusiness = @IdBusiness) ";

                command.Parameters.AddWithValue("@IdBusiness", pId);
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

        public async Task<IEnumerable<Business>> GetAllBusinessX()
        {

            List<Business> lista = new List<Business>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Business WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        // Mapearlas
                        Business oBusiness = new Business();
                        oBusiness.IdBusiness = (int)reader["IdBusiness"];
                        oBusiness.LegalID = reader["LegalID"].ToString();
                        oBusiness.Name = reader["Name"].ToString();
                        oBusiness.PhoneNumber= reader["PhoneNumber"].ToString();
                        oBusiness.Email= reader["Email"].ToString();
                        oBusiness.Photo = (byte[])reader["Photo"];
                        oBusiness.BillMessage = reader["BillMessage"].ToString();
                        BLLAddress bLLAddress = new BLLAddress();
                        oBusiness.Address = bLLAddress.GetAddressById((reader["IdAddress"].ToString()));
                        lista.Add(oBusiness);
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

        public async Task<IEnumerable<Business>> GetAllBusiness()
        {
            DataSet ds = null;
            List<Business> lista = new List<Business>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Business";
                //command.Parameters.AddWithValue("@IdBusiness", pDescripcion);
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
                        // Mapearlas
                        Business oBusiness = new Business();
                        oBusiness.IdBusiness = (int)dr["IdBusiness"];
                        oBusiness.LegalID = dr["LegalID"].ToString();
                        oBusiness.Name = dr["Name"].ToString();
                        oBusiness.PhoneNumber = dr["PhoneNumber"].ToString();
                        oBusiness.Email = dr["Email"].ToString();
                        oBusiness.Photo = (byte[])dr["Photo"];
                        oBusiness.BillMessage = dr["BillMessage"].ToString();
                        BLLAddress bLLAddress = new BLLAddress();
                        oBusiness.Address = bLLAddress.GetAddressById((dr["IdAddress"].ToString()));

                        lista.Add(oBusiness);
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


        public List<Business> GetBusinessByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Business> lista = new List<Business>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Business";
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
                        // Mapearlas
                        Business oBusiness = new Business();
                        oBusiness.IdBusiness = (int)dr["IdBusiness"];
                        oBusiness.LegalID = dr["LegalID"].ToString();
                        oBusiness.Name = dr["Name"].ToString();
                        oBusiness.PhoneNumber = dr["PhoneNumber"].ToString();
                        oBusiness.Email = dr["Email"].ToString();
                        oBusiness.Photo = (byte[])dr["Photo"];
                        oBusiness.BillMessage = dr["BillMessage"].ToString();
                        BLLAddress bLLAddress = new BLLAddress();
                        oBusiness.Address = bLLAddress.GetAddressById((dr["IdAddress"].ToString()));

                        lista.Add(oBusiness);
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

        public Business GetBusinessById(string pid)
        {
            DataSet ds = null;
            Business oBusiness = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Business Where IdBusiness = @IdBusiness ";
                command.Parameters.AddWithValue("@IdBusiness", pid);
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
                        oBusiness = new Business();
                        oBusiness.IdBusiness = (int)dr["IdBusiness"];
                        oBusiness.LegalID = dr["LegalID"].ToString();
                        oBusiness.Name = dr["Name"].ToString();
                        oBusiness.PhoneNumber = dr["PhoneNumber"].ToString();
                        oBusiness.Email = dr["Email"].ToString();
                        oBusiness.Photo = (byte[])dr["Photo"];
                        oBusiness.BillMessage = dr["BillMessage"].ToString();
                        BLLAddress bLLAddress = new BLLAddress();
                        oBusiness.Address = bLLAddress.GetAddressById((dr["IdAddress"].ToString()));
                    }
                }

                return oBusiness;
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


        public async Task<Business> SaveBusiness(Business pBusiness)
        {
            Business oBusiness = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Business(LegalId, Name, PhoneNumber, Email, Photo, BillMessage, IdAddress)
               VALUES (@LegalId, @Name, @PhoneNumber, @Email, @Photo, @BillMessage, @IdAddress)";

            try
            {
                command.Parameters.AddWithValue("@LegalId", pBusiness.LegalID);
                command.Parameters.AddWithValue("@Name", pBusiness.Name);
                command.Parameters.AddWithValue("@PhoneNumber", pBusiness.PhoneNumber);
                command.Parameters.AddWithValue("@Email", pBusiness.Email);
                command.Parameters.AddWithValue("@Photo", pBusiness.Photo);
                command.Parameters.AddWithValue("@BillMessage", pBusiness.BillMessage);
                command.Parameters.AddWithValue("@IdAddress", pBusiness.Address.IdAddress);
                //command.Parameters.AddWithValue("@IdBusiness", pBusiness.IdBusiness);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oBusiness = this.GetBusinessById(pBusiness.IdBusiness.ToString());
                }

                return oBusiness;

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

        public async Task<Business> UpdateBusiness(Business pBusiness)
        {

            string sql = @"UPDATE Business 
               SET LegalId = @LegalId, 
                   Name = @Name, 
                   PhoneNumber = @PhoneNumber, 
                   Email = @Email, 
                   Photo = @Photo, 
                   BillMessage = @BillMessage, 
                   IdAddress = @IdAddress
               WHERE IdBusiness = @IdBusiness";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Business oBusiness = new Business();
            try
            {
                command.Parameters.AddWithValue("@LegalId", pBusiness.LegalID);
                command.Parameters.AddWithValue("@Name", pBusiness.Name);
                command.Parameters.AddWithValue("@PhoneNumber", pBusiness.PhoneNumber);
                command.Parameters.AddWithValue("@Email", pBusiness.Email);
                command.Parameters.AddWithValue("@Photo", pBusiness.Photo);
                command.Parameters.AddWithValue("@BillMessage", pBusiness.BillMessage);
                command.Parameters.AddWithValue("@IdAddress", pBusiness.Address.IdAddress);
                command.Parameters.AddWithValue("@IdBusiness", pBusiness.IdBusiness);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oBusiness = this.GetBusinessById(pBusiness.IdBusiness.ToString());

                return oBusiness;

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
