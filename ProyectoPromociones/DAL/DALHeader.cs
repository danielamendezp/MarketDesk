using log4net;
using ProyectoPromociones.BLL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.Persistencia;
using ProyectoPromociones.UI;
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
    public class DALHeader : IDALHeader
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteHeader(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Header Where (IdHeader = @IdHeader) ";

                command.Parameters.AddWithValue("@IdHeader", pId);
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

        public async Task<IEnumerable<Header>> GetAllHeaderX()
        {

            List<Header> lista = new List<Header>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Header WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        BLLBusiness bLLBusiness = new BLLBusiness();
                        BLLCustomer customer = new BLLCustomer();
                        BLLPayment payment = new BLLPayment();
                        // Mapearlas
                        Header oHeader = new Header();
                        oHeader.IdHeader = (int)reader["IdHeader"];
                        oHeader.IssueDate = (DateTime)reader["IssueDate"];
                        oHeader.Business = bLLBusiness.GetBusinessById(reader["IdBusiness"].ToString());
                        oHeader.Customer = customer.GetCustomerById(reader["IdCustomer"].ToString());
                        oHeader.Payment = payment.GetPaymentById(reader["IdPayment"].ToString());
                        oHeader.State = bool.Parse(reader["State"].ToString());
                        lista.Add(oHeader);
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
        public async Task<IEnumerable<Header>> GetAllHeader()
        {
            DataSet ds = null;
            List<Header> lista = new List<Header>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Header";
                //command.Parameters.AddWithValue("@IdHeader", pDescripcion);
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
                        BLLBusiness bLLBusiness = new BLLBusiness();
                        BLLCustomer customer = new BLLCustomer();
                        BLLPayment payment = new BLLPayment();
                        // Mapearlas
                        Header oHeader = new Header();
                        oHeader.IdHeader = (int)dr["IdHeader"];
                        oHeader.IssueDate = (DateTime)dr["IssueDate"];
                        oHeader.Business = bLLBusiness.GetBusinessById(dr["IdBusiness"].ToString());
                        oHeader.Customer = customer.GetCustomerById(dr["IdCustomer"].ToString());
                        oHeader.Payment = payment.GetPaymentById(dr["IdPayment"].ToString());
                        oHeader.State = bool.Parse(dr["State"].ToString());
                        lista.Add(oHeader);

                        lista.Add(oHeader);
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

        public List<Header> GetHeaderByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Header> lista = new List<Header>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Header ";
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
                        BLLBusiness bLLBusiness = new BLLBusiness();
                        BLLCustomer customer = new BLLCustomer();
                        BLLPayment payment = new BLLPayment();
                        // Mapearlas
                        Header oHeader = new Header();
                        oHeader.IdHeader = (int)dr["IdHeader"];
                        oHeader.IssueDate = (DateTime)dr["IssueDate"];
                        oHeader.Business = bLLBusiness.GetBusinessById(dr["IdBusiness"].ToString());
                        oHeader.Customer = customer.GetCustomerById(dr["IdCustomer"].ToString());
                        oHeader.Payment = payment.GetPaymentById(dr["IdPayment"].ToString());
                        oHeader.State = bool.Parse(dr["State"].ToString());
                        lista.Add(oHeader);

                        lista.Add(oHeader);
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

        public Header GetHeaderById(string pid)
        {
            DataSet ds = null;
            Header oHeader = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Header Where IdHeader = @IdHeader ";
                command.Parameters.AddWithValue("@IdHeader", pid);
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
                        oHeader = new Header();
                        BLLBusiness bLLBusiness = new BLLBusiness();
                        BLLCustomer customer = new BLLCustomer();
                        BLLPayment payment = new BLLPayment();
                        // Mapearlas
                        oHeader.IdHeader = (int)dr["IdHeader"];
                        oHeader.IssueDate = (DateTime)dr["IssueDate"];
                        oHeader.Business = bLLBusiness.GetBusinessById(dr["IdBusiness"].ToString());
                        oHeader.Customer = customer.GetCustomerById(dr["IdCustomer"].ToString());
                        oHeader.Payment = payment.GetPaymentById(dr["IdPayment"].ToString());
                        oHeader.State = bool.Parse(dr["State"].ToString());
                    }
                }

                return oHeader;
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


        public async Task<Header> SaveHeader(Header pHeader)
        {
            Header oHeader = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Header(IssueDate, IdBusiness, IdCustomer, IdPayment, State)
               VALUES (@IssueDate, @IdBusiness, @IdCustomer, @IdPayment, @State)";


            try
            {
                //command.Parameters.AddWithValue("@IdHeader", pHeader.IdHeader);
                command.Parameters.AddWithValue("@IssueDate", pHeader.IssueDate);
                command.Parameters.AddWithValue("@IdBusiness", pHeader.Business.IdBusiness);
                command.Parameters.AddWithValue("@IdCustomer", pHeader.Customer.IdCustomer);
                command.Parameters.AddWithValue("@IdPayment", pHeader.Payment.IdPayment);
                command.Parameters.AddWithValue("@State", pHeader.State);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oHeader = this.GetHeaderById(pHeader.IdHeader.ToString());
                }

                return oHeader;

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

        public async Task<Header> UpdateHeader(Header pHeader)
        {

            string sql = @"UPDATE Header 
               SET IssueDate = @IssueDate, 
                   IdBusiness = @IdBusiness, 
                   IdCustomer = @IdCustomer, 
                   IdPayment = @IdPayment,
                    State=@State
               WHERE IdHeader = @IdHeader";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Header oHeader = new Header();
            try
            {
                command.Parameters.AddWithValue("@IdHeader", pHeader.IdHeader);
                command.Parameters.AddWithValue("@IssueDate", pHeader.IssueDate);
                command.Parameters.AddWithValue("@IdBusiness", pHeader.Business.IdBusiness);
                command.Parameters.AddWithValue("@IdCustomer", pHeader.Customer.IdCustomer);
                command.Parameters.AddWithValue("@IdPayment", pHeader.Payment.IdPayment);
                command.Parameters.AddWithValue("@State", pHeader.State);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oHeader = this.GetHeaderById(pHeader.IdHeader.ToString());

                return oHeader;

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
