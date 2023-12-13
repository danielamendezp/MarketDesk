using log4net;
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
    public class DALSupplier : IDALSupplier
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteSupplier(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Supplier Where (IdSupplier = @IdSupplier) ";

                command.Parameters.AddWithValue("@IdSupplier", pId);
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

        public async Task<IEnumerable<Supplier>> GetAllSupplierX()
        {

            List<Supplier> lista = new List<Supplier>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Supplier WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        // Mapearlas
                        Supplier oSupplier = new Supplier();
                        oSupplier.IdSupplier = (int)reader["IdSupplier"];
                        oSupplier.Name = reader["Name"].ToString();
                        oSupplier.PhoneNumber= reader["PhoneNumber"].ToString();
                        oSupplier.Email= reader["Email"].ToString();
                       
                        lista.Add(oSupplier);
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

        public async Task<IEnumerable<Supplier>> GetAllSupplier()
        {
            DataSet ds = null;
            List<Supplier> lista = new List<Supplier>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Supplier ";
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
                        Supplier oSupplier = new Supplier();
                        oSupplier.IdSupplier = (int)dr["IdSupplier"];
                        oSupplier.Name = dr["Name"].ToString();
                        oSupplier.PhoneNumber = dr["PhoneNumber"].ToString();
                        oSupplier.Email = dr["Email"].ToString();

                        lista.Add(oSupplier);
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

        public List<Supplier> GetSupplierByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Supplier> lista = new List<Supplier>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Supplier ";
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
                        Supplier oSupplier = new Supplier();
                        oSupplier.IdSupplier = (int)dr["IdSupplier"];
                        oSupplier.Name = dr["Name"].ToString();
                        oSupplier.PhoneNumber = dr["PhoneNumber"].ToString();
                        oSupplier.Email = dr["Email"].ToString();

                        lista.Add(oSupplier);
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

        public Supplier GetSupplierById(string pid)
        {
            DataSet ds = null;
            Supplier oSupplier = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Supplier Where IdSupplier = @IdSupplier ";
                command.Parameters.AddWithValue("@IdSupplier", pid);
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
                        oSupplier = new Supplier();
                        oSupplier.IdSupplier = (int)dr["IdSupplier"];
                        oSupplier.Name = dr["Name"].ToString();
                        oSupplier.PhoneNumber = dr["PhoneNumber"].ToString();
                        oSupplier.Email = dr["Email"].ToString();
                    }
                }

                return oSupplier;
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


        public async Task<Supplier> SaveSupplier(Supplier pSupplier)
        {
            Supplier oSupplier = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Supplier(Name, PhoneNumber, Email)
               VALUES (@Name, @PhoneNumber, @Email)";

            try
            {
                //command.Parameters.AddWithValue("@IdSupplier", pSupplier.IdSupplier);
                command.Parameters.AddWithValue("@Name", pSupplier.Name);
                command.Parameters.AddWithValue("@PhoneNumber", pSupplier.PhoneNumber);
                command.Parameters.AddWithValue("@Email", pSupplier.Email);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oSupplier = this.GetSupplierById(pSupplier.IdSupplier.ToString());
                }

                return oSupplier;

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

        public async Task<Supplier> UpdateSupplier(Supplier pSupplier)
        {

            string sql = @"UPDATE Supplier 
               SET Name = @Name, PhoneNumber=@PhoneNumber, Email=@Email
               WHERE IdSupplier = @IdSupplier";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Supplier oSupplier = new Supplier();
            try
            {
                command.Parameters.AddWithValue("@IdSupplier", pSupplier.IdSupplier);
                command.Parameters.AddWithValue("@Name", pSupplier.Name);
                command.Parameters.AddWithValue("@PhoneNumber", pSupplier.PhoneNumber);
                command.Parameters.AddWithValue("@Email", pSupplier.Email);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oSupplier = this.GetSupplierById(pSupplier.IdSupplier.ToString());

                return oSupplier;

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
