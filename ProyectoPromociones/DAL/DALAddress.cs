using log4net;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.Patrones;
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
    public class DALAddress : IDALAddress
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteAddress(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Address Where (IdAddress = @IdAddress) ";

                command.Parameters.AddWithValue("@IdAddress", pId);
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

        public async Task<IEnumerable<Address>> GetAllAddressX()
        {

            List<Address> lista = new List<Address>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Address";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        // Mapearlas
                        Address oAddress = new Address();
                        FacadeAddress facadeAddress = new FacadeAddress();
                        // Mapearlas
                        oAddress.IdAddress = (int)reader["IdAddress"];
                        oAddress.Provincia = (Provincias)facadeAddress.ObtenerProvincia(reader["IdProvincia"].ToString());
                        oAddress.Canton = (Cantones)facadeAddress.ObtenerCanton((int)reader["IdCanton"]);
                        oAddress.Distrito = (Distritos)facadeAddress.ObtenerDistrito((int)reader["IdDistrito"]);
                        oAddress.Description = reader["Description"].ToString();
                        lista.Add(oAddress);
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

        public async Task<IEnumerable<Address>> GetAllAddress()
        {
            DataSet ds = null;
            List<Address> lista = new List<Address>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Address";
               /* command.Parameters.AddWithValue("@IdAddress", pAddress.IdAddress);
                command.Parameters.AddWithValue("@IdProvincia", pAddress.Provincia.id);
                command.Parameters.AddWithValue("@IdCanton", pAddress.Canton.id);
                command.Parameters.AddWithValue("@IdDistrito", pAddress.Distrito.id);
                command.Parameters.AddWithValue("@Description", pAddress.Description);*/
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
                        Address oAddress = new Address();
                        FacadeAddress facadeAddress = new FacadeAddress();
                        // Mapearlas
                        oAddress.IdAddress = (int)dr["IdAddress"];
                        oAddress.Provincia = (Provincias)facadeAddress.ObtenerProvincia(dr["IdProvincia"].ToString());
                        oAddress.Canton = (Cantones)facadeAddress.ObtenerCanton((int)dr["IdCanton"]);
                        oAddress.Distrito = (Distritos)facadeAddress.ObtenerDistrito((int)dr["IdDistrito"]);
                        oAddress.Description = dr["Description"].ToString();

                        lista.Add(oAddress);
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

        public List<Address> GetAddressByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Address> lista = new List<Address>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select IdAddress, Name from Address";

                command.Parameters.AddWithValue("@Name", pDescripcion);
                //command.Parameters.AddWithValue("@IdAddress", pDescripcion);
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
                        Address oAddress = new Address();
                        FacadeAddress facadeAddress = new FacadeAddress();
                        // Mapearlas
                        oAddress.IdAddress = (int)dr["IdAddress"];
                        oAddress.Provincia = (Provincias)facadeAddress.ObtenerProvincia(dr["IdProvincia"].ToString());
                        oAddress.Canton = (Cantones)facadeAddress.ObtenerCanton((int)dr["IdCanton"]);
                        oAddress.Distrito = (Distritos)facadeAddress.ObtenerDistrito((int)dr["IdDistrito"]);
                        oAddress.Description = dr["Description"].ToString();

                        lista.Add(oAddress);
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

        public Address GetAddressById(string pid)
        {
            DataSet ds = null;
            Address oAddress = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Address Where IdAddress = @IdAddress ";
                command.Parameters.AddWithValue("@IdAddress", pid);
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

                        oAddress = new Address();
                        FacadeAddress facadeAddress = new FacadeAddress();
                        // Mapearlas
                        oAddress.IdAddress = (int)dr["IdAddress"];
                        oAddress.Provincia = (Provincias)facadeAddress.ObtenerProvincia(dr["IdProvincia"].ToString());
                        oAddress.Canton = (Cantones)facadeAddress.ObtenerCanton((int)dr["IdCanton"]);
                        oAddress.Distrito = (Distritos)facadeAddress.ObtenerDistrito((int)dr["IdDistrito"]);
                        oAddress.Description = dr["Description"].ToString();
                    }
                }

                return oAddress;
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


        public async Task<Address> SaveAddress(Address pAddress)
        {
            Address oAddress = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Address(IdProvincia, IdCanton, IdDistrito, Description)
                                      VALUES (@IdProvincia, @IdCanton, @IdDistrito, @Description)";

            try
            {
                command.Parameters.AddWithValue("@IdAddress", pAddress.IdAddress);
                command.Parameters.AddWithValue("@IdProvincia", pAddress.Provincia.id);
                command.Parameters.AddWithValue("@IdCanton", pAddress.Canton.id);
                command.Parameters.AddWithValue("@IdDistrito", pAddress.Distrito.id);
                command.Parameters.AddWithValue("@Description", pAddress.Description);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oAddress = this.GetAddressById(pAddress.IdAddress.ToString());
                }

                return oAddress;

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

        public async Task<Address> UpdateAddress(Address pAddress)
        {

            string sql = @"UPDATE Address 
                        SET IdProvincia = @IdProvincia, 
                            IdCanton = @IdCanton, 
                            IdDistrito = @IdDistrito, 
                            Description=@Description
                        WHERE (IdAddress = @IdAddress)";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Address oAddress = new Address();
            try
            {
                command.Parameters.AddWithValue("@IdAddress", pAddress.IdAddress);
                command.Parameters.AddWithValue("@IdProvincia", pAddress.Provincia.id);
                command.Parameters.AddWithValue("@IdCanton", pAddress.Canton.id);
                command.Parameters.AddWithValue("@IdDistrito", pAddress.Distrito.id);
                command.Parameters.AddWithValue("@Description", pAddress.Description);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oAddress = this.GetAddressById(pAddress.IdAddress.ToString());

                return oAddress;

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
