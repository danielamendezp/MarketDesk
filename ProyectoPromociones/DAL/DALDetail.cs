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
    public class DALDetail : IDALDetail
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteDetail(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Detail Where (IdDetail = @IdDetail) ";

                command.Parameters.AddWithValue("@IdDetail", pId);
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

        public async Task<IEnumerable<Detail>> GetAllDetailX()
        {

            List<Detail> lista = new List<Detail>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Detail";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        BLLHeader bLLHeader = new BLLHeader();
                        BLLProduct bLLProduct = new BLLProduct();
                        // Mapearlas
                        Detail oDetail = new Detail();
                        oDetail.IdDetail = (int)reader["IdDetail"];
                        oDetail.Header = bLLHeader.GetHeaderById(reader["IdHeader"].ToString());
                        oDetail.ProductQuantity = (int)reader["ProductQuantity"];
                        oDetail.Product = bLLProduct.GetProductById(reader["IdProduct"].ToString()); 
                        lista.Add(oDetail);
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

        public async Task<IEnumerable<Detail>> GetAllDetail()
        {
            DataSet ds = null;
            List<Detail> lista = new List<Detail>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Detail";
                //command.Parameters.AddWithValue("@IdDetail", pDescripcion);
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
                        BLLHeader bLLHeader = new BLLHeader();
                        BLLProduct bLLProduct = new BLLProduct();
                        // Mapearlas
                        Detail oDetail = new Detail();
                        oDetail.IdDetail = (int)dr["IdDetail"];
                        oDetail.Header = bLLHeader.GetHeaderById(dr["IdHeader"].ToString());
                        oDetail.ProductQuantity = (int)dr["ProductQuantity"];
                        oDetail.Product = bLLProduct.GetProductById(dr["IdProduct"].ToString()); 

                        lista.Add(oDetail);
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

        public List<Detail> GetDetailByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Detail> lista = new List<Detail>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Detail ";
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
                        BLLHeader bLLHeader = new BLLHeader();
                        BLLProduct bLLProduct = new BLLProduct();
                        // Mapearlas
                        Detail oDetail = new Detail();
                        oDetail.IdDetail = (int)dr["IdDetail"];
                        oDetail.Header = bLLHeader.GetHeaderById(dr["IdHeader"].ToString());
                        oDetail.ProductQuantity = (int)dr["ProductQuantity"];
                        oDetail.Product = bLLProduct.GetProductById(dr["IdProduct"].ToString()); 

                        lista.Add(oDetail);
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

        public Detail GetDetailById(string pid)
        {
            DataSet ds = null;
            Detail oDetail = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Detail Where IdDetail = @IdDetail ";
                command.Parameters.AddWithValue("@IdDetail", pid);
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
                        oDetail = new Detail();
                        // Mapearlas
                        BLLHeader bLLHeader = new BLLHeader();
                        BLLProduct bLLProduct = new BLLProduct();
                        // Mapearlas
                        oDetail.IdDetail = (int)dr["IdDetail"];
                        oDetail.Header = bLLHeader.GetHeaderById(dr["IdHeader"].ToString());
                        oDetail.ProductQuantity = (int)dr["ProductQuantity"];
                        oDetail.Product = bLLProduct.GetProductById(dr["IdProduct"].ToString()); 
                    }
                }

                return oDetail;
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


        public async Task<Detail> SaveDetail(Detail pDetail)
        {
            Detail oDetail = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Detail(IdHeader, ProductQuantity, IdProduct)
               VALUES (@IdHeader, @ProductQuantity, @IdProduct)";

            try
            {
                //command.Parameters.AddWithValue("@IdDetail", pDetail.IdDetail);
                command.Parameters.AddWithValue("@IdHeader", pDetail.Header.IdHeader);
                command.Parameters.AddWithValue("@ProductQuantity", pDetail.ProductQuantity);
                command.Parameters.AddWithValue("@IdProduct", pDetail.Product.IdProduct);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oDetail = this.GetDetailById(pDetail.IdDetail.ToString());
                }

                return oDetail;

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

        public async Task<Detail> UpdateDetail(Detail pDetail)
        {

            string sql = @"UPDATE Detail 
               SET IdHeader = @IdHeader, 
                   ProductQuantity = @ProductQuantity, 
                   IdProduct = @IdProduct
               WHERE IdDetail = @IdDetail";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Detail oDetail = new Detail();
            try
            {
                command.Parameters.AddWithValue("@IdDetail", pDetail.IdDetail);
                command.Parameters.AddWithValue("@IdHeader", pDetail.Header.IdHeader);
                command.Parameters.AddWithValue("@ProductQuantity", pDetail.ProductQuantity);
                command.Parameters.AddWithValue("@IdProduct", pDetail.Product.IdProduct);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oDetail = this.GetDetailById(pDetail.IdDetail.ToString());

                return oDetail;

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
