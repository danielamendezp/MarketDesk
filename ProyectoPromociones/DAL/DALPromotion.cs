using log4net;
using ProyectoPromociones.BLL;
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
    public class DALPromotion : IDALPromotion
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeletePromotion(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Promotion Where (IdPromotion = @IdPromotion) ";

                command.Parameters.AddWithValue("@IdPromotion", pId);
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

        public async Task<IEnumerable<Promotion>> GetAllPromotionX()
        {

            List<Promotion> lista = new List<Promotion>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Promotion";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        // Mapearlas
                        Promotion oPromotion = new Promotion();
                        oPromotion.IdPromotion = (int)reader["IdPromotion"];
                        oPromotion.InitialTime = (DateTime)reader["InitialTime"];
                        oPromotion.FinalTime = (DateTime)reader["FinalTime"];
                        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
                        oPromotion.PromotionProduct = factoryMaintenanceVisualize.GetProductById((int)reader["PromotionProduct"]);
                        oPromotion.GiftPromotion = factoryMaintenanceVisualize.GetProductById((int)reader["GiftPromotion"]);
                        oPromotion.QtyPromotionProduct = (int)reader["QtyPromotionProduct"];
                        oPromotion.QtyGiftPromotion = (int)reader["QtyGiftPromotion"];
                        oPromotion.Description = (string)reader["Description"];
                        oPromotion.Discount = (double)reader["Discount"];
                        oPromotion.BuyAmount = (double)reader["BuyAmount"];

                        lista.Add(oPromotion);
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


        public async Task<IEnumerable<Promotion>> GetAllPromotion()
        {
            DataSet ds = null;
            List<Promotion> lista = new List<Promotion>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Promotion";
                //command.Parameters.AddWithValue("@IdPromotion", pDescripcion);
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
                        Promotion oPromotion = new Promotion();
                        oPromotion.IdPromotion = (int)dr["IdPromotion"];
                        oPromotion.InitialTime = (DateTime)dr["InitialTime"];
                        oPromotion.FinalTime = (DateTime)dr["FinalTime"];
                        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
                        oPromotion.PromotionProduct = factoryMaintenanceVisualize.GetProductById((int)dr["PromotionProduct"]);
                        oPromotion.GiftPromotion = factoryMaintenanceVisualize.GetProductById((int)dr["GiftPromotion"]);
                        oPromotion.QtyPromotionProduct = (int)dr["QtyPromotionProduct"];
                        oPromotion.QtyGiftPromotion = (int)dr["QtyGiftPromotion"];
                        oPromotion.Description = (string)dr["Description"];
                        oPromotion.Discount = (double)dr["Discount"];
                        oPromotion.BuyAmount = (double)dr["BuyAmount"];

                        lista.Add(oPromotion);
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
        public List<Promotion> GetPromotionByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Promotion> lista = new List<Promotion>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Promotion";
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
                        Promotion oPromotion = new Promotion();
                        oPromotion.IdPromotion = (int)dr["IdPromotion"];
                        oPromotion.InitialTime = (DateTime)dr["InitialTime"];
                        oPromotion.FinalTime = (DateTime)dr["FinalTime"];
                        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
                        oPromotion.PromotionProduct = factoryMaintenanceVisualize.GetProductById((int)dr["PromotionProduct"]);
                        oPromotion.GiftPromotion = factoryMaintenanceVisualize.GetProductById((int)dr["GiftPromotion"]);
                        oPromotion.QtyPromotionProduct = (int)dr["QtyPromotionProduct"];
                        oPromotion.QtyGiftPromotion = (int)dr["QtyGiftPromotion"];
                        oPromotion.Description = (string)dr["Description"];
                        oPromotion.Discount = (double)dr["Discount"];
                        oPromotion.BuyAmount = (double)dr["BuyAmount"];

                        lista.Add(oPromotion);
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

        public Promotion GetPromotionById(string pid)
        {
            DataSet ds = null;
            Promotion oPromotion = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Promotion Where IdPromotion = @IdPromotion ";
                command.Parameters.AddWithValue("@IdPromotion", pid);
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
                        oPromotion = new Promotion();
                        oPromotion.IdPromotion = (int)dr["IdPromotion"];
                        oPromotion.InitialTime = (DateTime)dr["InitialTime"];
                        oPromotion.FinalTime = (DateTime)dr["FinalTime"];
                        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
                        oPromotion.PromotionProduct = factoryMaintenanceVisualize.GetProductById((int)dr["PromotionProduct"]);
                        oPromotion.GiftPromotion = factoryMaintenanceVisualize.GetProductById((int)dr["GiftPromotion"]);
                        oPromotion.QtyPromotionProduct = (int)dr["QtyPromotionProduct"];
                        oPromotion.QtyGiftPromotion = (int)dr["QtyGiftPromotion"];
                        oPromotion.Description = (string)dr["Description"];
                        oPromotion.Discount = (double)dr["Discount"];
                        oPromotion.BuyAmount = (double)dr["BuyAmount"];

                    }
                }

                return oPromotion;
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


        public async Task<Promotion> SavePromotion(Promotion pPromotion)
        {
            Promotion oPromotion = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Promotion(InitialTime, FinalTime, PromotionProduct, GiftPromotion, QtyPromotionProduct, QtyGiftPromotion, Description, Discount, BuyAmount)
                                        VALUES (@InitialTime, @FinalTime, @PromotionProduct, @GiftPromotion, @QtyPromotionProduct, @QtyGiftPromotion, @Description, @Discount, @BuyAmount)";
            int idProductGift = 1;
            int idProductPromotion = 1;
            try
            {
                if(pPromotion.GiftPromotion!=null)
                {
                    idProductGift = pPromotion.GiftPromotion.IdProduct;
                }
                if (pPromotion.PromotionProduct != null)
                {
                    idProductPromotion = pPromotion.PromotionProduct.IdProduct;
                }
                command.Parameters.AddWithValue("@IdPromotion", pPromotion.IdPromotion);
                command.Parameters.AddWithValue("@InitialTime", pPromotion.InitialTime);
                command.Parameters.AddWithValue("@FinalTime", pPromotion.FinalTime);
                command.Parameters.AddWithValue("@PromotionProduct", idProductPromotion);
                command.Parameters.AddWithValue("@GiftPromotion", idProductGift);
                command.Parameters.AddWithValue("@QtyPromotionProduct", pPromotion.QtyPromotionProduct);
                command.Parameters.AddWithValue("@QtyGiftPromotion", pPromotion.QtyGiftPromotion);
                command.Parameters.AddWithValue("@Description", pPromotion.Description);
                command.Parameters.AddWithValue("@Discount", pPromotion.Discount);
                command.Parameters.AddWithValue("@BuyAmount", pPromotion.BuyAmount);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oPromotion = this.GetPromotionById(pPromotion.IdPromotion.ToString());
                }

                return oPromotion;

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

        public async Task<Promotion> UpdatePromotion(Promotion pPromotion)
        {

            string sql = @"UPDATE Promotion 
                       SET InitialTime = @InitialTime, 
                           FinalTime = @FinalTime, 
                           PromotionProduct = @PromotionProduct, 
                           GiftPromotion = @GiftPromotion, 
                           QtyPromotionProduct = @QtyPromotionProduct, 
                           QtyGiftPromotion = @QtyGiftPromotion, 
                           Description = @Description, 
                           Discount = @Discount, 
                           BuyAmount = @BuyAmount
                       WHERE IdPromotion = @IdPromotion";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Promotion oPromotion = new Promotion();
            int idProductGift = 1;
            int idProductPromotion = 1;
            try
            {
                if (pPromotion.GiftPromotion != null)
                {
                    idProductGift = pPromotion.GiftPromotion.IdProduct;
                }
                if (pPromotion.PromotionProduct != null)
                {
                    idProductPromotion = pPromotion.PromotionProduct.IdProduct;
                }
                command.Parameters.AddWithValue("@IdPromotion", pPromotion.IdPromotion);
                command.Parameters.AddWithValue("@InitialTime", pPromotion.InitialTime);
                command.Parameters.AddWithValue("@FinalTime", pPromotion.FinalTime);
                command.Parameters.AddWithValue("@PromotionProduct", idProductPromotion);
                command.Parameters.AddWithValue("@GiftPromotion", idProductGift);
                command.Parameters.AddWithValue("@QtyPromotionProduct", pPromotion.QtyPromotionProduct);
                command.Parameters.AddWithValue("@QtyGiftPromotion", pPromotion.QtyGiftPromotion);
                command.Parameters.AddWithValue("@Description", pPromotion.Description);
                command.Parameters.AddWithValue("@Discount", pPromotion.Discount);
                command.Parameters.AddWithValue("@BuyAmount", pPromotion.BuyAmount);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oPromotion = this.GetPromotionById(pPromotion.IdPromotion.ToString());

                return oPromotion;

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
