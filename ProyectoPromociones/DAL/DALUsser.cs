using log4net;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum;
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;
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
    public class DALUsser : IDALUsser
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteUsser(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Usser Where (IdUser = @IdUser) ";

                command.Parameters.AddWithValue("@IdUsser", pId);
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

        public async Task<IEnumerable<Usser>> GetAllUsserX()
        {

            List<Usser> lista = new List<Usser>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Usser";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        // Mapearlas
                        Usser oUsser = new Usser();
                        oUsser.IdUsser = (int)reader["IdUsser"];
                        oUsser.UserName = reader["UserName"].ToString();
                        oUsser.PersonName = reader["PersonName"].ToString();
                        oUsser.Password = reader["Password"].ToString();
                        oUsser.ETypeUser = EUserProgram.BuscarUserRol(reader["ETypeUser"].ToString());
                        oUsser.Active = (bool)reader["Active"];
                        oUsser.LastLogin = (DateTime)reader["LastLogin"];
                        lista.Add(oUsser);
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

        public async Task<IEnumerable<Usser>> GetAllUsser()
        {
            DataSet ds = null;
            List<Usser> lista = new List<Usser>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Usser";
                //command.Parameters.AddWithValue("@IdUsser", pDescripcion);
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
                        Usser oUsser = new Usser();
                        oUsser.IdUsser = (int)dr["IdUser"];
                        oUsser.UserName = dr["UserName"].ToString();
                        oUsser.PersonName = dr["PersonName"].ToString();
                        oUsser.Password = dr["Password"].ToString();
                        oUsser.ETypeUser = EUserProgram.BuscarUserRol(dr["ETypeUser"].ToString());
                        oUsser.Active = (bool)dr["Active"];
                        oUsser.LastLogin = (DateTime)dr["LastLogin"];

                        lista.Add(oUsser);
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


        public List<Usser> GetUsserByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Usser> lista = new List<Usser>();
            SqlCommand command = new SqlCommand();

            try
            {
                //string sql = @"select * from Usser";
                string sql = @"select IdUser, UserName, PersonName, Password, ETypeUser, Active, LastLogin from Usser";
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
                        Usser oUsser = new Usser();
                        oUsser.IdUsser = (int)dr["IdUser"];
                        oUsser.UserName = dr["UserName"].ToString();
                        oUsser.PersonName = dr["PersonName"].ToString();
                        oUsser.Password = dr["Password"].ToString();
                        oUsser.ETypeUser = EUserProgram.BuscarUserRol(dr["ETypeUser"].ToString());
                        oUsser.Active = (bool)dr["Active"];
                        oUsser.LastLogin = (DateTime)dr["LastLogin"];


                        lista.Add(oUsser);
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

        public Usser GetUsserById(string pid)
        {
            DataSet ds = null;
            Usser oUsser = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Usser Where IdUser = @IdUser ";
                command.Parameters.AddWithValue("@IdUser", pid);
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
                        oUsser = new Usser();
                        oUsser.IdUsser = (int)dr["IdUser"];
                        oUsser.UserName = dr["UserName"].ToString();
                        oUsser.PersonName = dr["PersonName"].ToString();
                        oUsser.Password = dr["Password"].ToString();
                        oUsser.ETypeUser = EUserProgram.BuscarUserRol(dr["ETypeUser"].ToString());
                        oUsser.Active = (bool)dr["Active"];
                        oUsser.LastLogin = (DateTime)dr["LastLogin"];

                    }
                }

                return oUsser;
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


        public async Task<Usser> SaveUsser(Usser pUsser)
        {
            Usser oUsser = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Usser(UserName, PersonName, Password, ETypeUser, Active, LastLogin)
               VALUES (@UserName, @PersonName, @Password, @ETypeUser, @Active, @LastLogin)";

            try
            {
               // command.Parameters.AddWithValue("@IdUser", pUsser.IdUsser);
                command.Parameters.AddWithValue("@UserName", pUsser.UserName);
                command.Parameters.AddWithValue("@PersonName", pUsser.PersonName);
                command.Parameters.AddWithValue("@Password",pUsser.Password);
                command.Parameters.AddWithValue("@ETypeUser", pUsser.ETypeUser.ToString());
                command.Parameters.AddWithValue("@Active", pUsser.Active);
                command.Parameters.AddWithValue("@LastLogin", pUsser.LastLogin);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oUsser = this.GetUsserById(pUsser.IdUsser.ToString());
                }

                return oUsser;

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

        public async Task<Usser> UpdateUsser(Usser pUsser)
        {

            string sql = @"UPDATE Usser 
               SET UserName = @UserName, 
                   PersonName = @PersonName, 
                   Password = @Password, 
                   ETypeUser = @ETypeUser, 
                   Active = @Active, 
                   LastLogin = @LastLogin
               WHERE IdUser = @IdUser";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Usser oUsser = new Usser();
            try
            {
                command.Parameters.AddWithValue("@IdUser", pUsser.IdUsser);
                command.Parameters.AddWithValue("@UserName", pUsser.UserName);
                command.Parameters.AddWithValue("@PersonName", pUsser.PersonName);
                command.Parameters.AddWithValue("@Password", pUsser.Password);
                command.Parameters.AddWithValue("@ETypeUser", pUsser.ETypeUser.ToString());
                command.Parameters.AddWithValue("@Active", pUsser.Active);
                command.Parameters.AddWithValue("@LastLogin", pUsser.LastLogin);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oUsser = this.GetUsserById(pUsser.IdUsser.ToString());

                return oUsser;

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
