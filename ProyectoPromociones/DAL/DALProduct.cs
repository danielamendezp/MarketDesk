using log4net;
using ProyectoPromociones.BLL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.Persistencia;
using ProyectoPromociones.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.DAL
{
    public class DALProduct : IDALProduct
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteProduct(string pId)
        {
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {
                string sql = @"Delete from  Product Where (IdProduct = @IdProduct) ";

                command.Parameters.AddWithValue("@IdProduct", pId);
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

        public async Task<IEnumerable<Product>> GetAllProductX()
        {

            List<Product> lista = new List<Product>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from  Product";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow reader in dt.Rows)
                    {
                        
                        // Mapearlas
                        Product oProduct = new Product();
                        oProduct.IdProduct = (int)reader["IdProduct"];
                        oProduct.CodigoBarras = reader["CodigoBarras"].ToString();
                        oProduct.Name = reader["Name"].ToString();
                        oProduct.ExistingQuantity = (int)reader["ExistingQuantity"];
                        BLLCategory Category = new BLLCategory();
                        BLLSupplier bLLSupplier = new BLLSupplier();
                        BLLUsser bLLUsser = new BLLUsser();
                        oProduct.Category = Category.GetCategoryById(reader["Category"].ToString());
                        oProduct.Supplier = bLLSupplier.GetSupplierById(reader["Supplier"].ToString());
                        oProduct.Cost = (double)reader["Cost"];
                        oProduct.ProfitPercentage = (double)reader["ProfitPercentage"];
                        oProduct.Tax = (double)reader["Tax"];
                        oProduct.ListPrice = (double)reader["ListPrice"];
                        oProduct.User = bLLUsser.GetUsserById(reader["IDUser"].ToString());
                        oProduct.Photo = (byte[])reader["Photo"];

                        lista.Add(oProduct);
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

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            DataSet ds = null;
            List<Product> lista = new List<Product>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @"select * from Product";
                //command.Parameters.AddWithValue("@IdProduct", pDescripcion);
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
                        Product oProduct = new Product();
                        oProduct.IdProduct = (int)dr["IdProduct"];
                        oProduct.CodigoBarras = dr["CodigoBarras"].ToString();
                        oProduct.Name = dr["Name"].ToString();
                        oProduct.ExistingQuantity = (int)dr["ExistingQuantity"];
                        BLLCategory category = new BLLCategory();
                        BLLSupplier bLLSupplier = new BLLSupplier();
                        BLLUsser bLLUsser = new BLLUsser();
                        oProduct.Category = category.GetCategoryById(dr["Category"].ToString());
                        oProduct.Supplier = bLLSupplier.GetSupplierById(dr["Supplier"].ToString());
                        oProduct.Cost = (double)dr["Cost"];
                        oProduct.ProfitPercentage = (double)dr["ProfitPercentage"];
                        oProduct.Tax = (double)dr["Tax"];
                        oProduct.ListPrice = (double)dr["ListPrice"];
                        oProduct.User = bLLUsser.GetUsserById(dr["IDUser"].ToString());
                        oProduct.Photo = (byte[])dr["Photo"];
                        lista.Add(oProduct);
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

        public List<Product> GetProductByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Product> lista = new List<Product>();
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Product";
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
                        Product oProduct = new Product();
                        oProduct.IdProduct = (int)dr["IdProduct"];
                        oProduct.CodigoBarras = dr["CodigoBarras"].ToString();
                        oProduct.Name = dr["Name"].ToString();
                        oProduct.ExistingQuantity = (int)dr["ExistingQuantity"];
                        BLLCategory Category = new BLLCategory();
                        BLLSupplier bLLSupplier = new BLLSupplier();
                        BLLUsser bLLUsser = new BLLUsser();
                        oProduct.Category = Category.GetCategoryById(dr["Category"].ToString());
                        oProduct.Supplier = bLLSupplier.GetSupplierById(dr["Supplier"].ToString());
                        oProduct.Cost = (double)dr["Cost"];
                        oProduct.ProfitPercentage = (double)dr["ProfitPercentage"];
                        oProduct.Tax = (double)dr["Tax"];
                        oProduct.ListPrice = (double)dr["ListPrice"];
                        oProduct.User = bLLUsser.GetUsserById(dr["IDUser"].ToString());
                        oProduct.Photo = (byte[])dr["Photo"];
                        lista.Add(oProduct);
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


        public Product GetProductById(string pid)
        {
            DataSet ds = null;
            Product oProduct = null;
            SqlCommand command = new SqlCommand();

            try
            {
                string sql = @" select * from Product Where IdProduct = @IdProduct; ";
                command.Parameters.AddWithValue("@IdProduct", pid);
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

                        oProduct = new Product();
                        oProduct.IdProduct = (int)dr["IdProduct"];
                        oProduct.CodigoBarras = dr["CodigoBarras"].ToString();
                        oProduct.Name = dr["Name"].ToString();
                        oProduct.ExistingQuantity = (int)dr["ExistingQuantity"];
                        BLLCategory Category = new BLLCategory();
                        BLLSupplier bLLSupplier = new BLLSupplier();
                        BLLUsser bLLUsser = new BLLUsser();
                        oProduct.Category = Category.GetCategoryById(dr["Category"].ToString());
                        oProduct.Supplier = bLLSupplier.GetSupplierById(dr["Supplier"].ToString());
                        oProduct.Cost = (double)dr["Cost"];
                        oProduct.ProfitPercentage = (double)dr["ProfitPercentage"];
                        oProduct.Tax = (double)dr["Tax"];
                        oProduct.ListPrice = (double)dr["ListPrice"];
                        oProduct.User = bLLUsser.GetUsserById(dr["IDUser"].ToString());
                        oProduct.Photo = (byte[])dr["Photo"];
                    }
                }

                return oProduct;
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
        public async Task<Product> SaveProduct(Product pProduct)
        {
            Product oProduct = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"INSERT INTO Product(CodigoBarras, Name, ExistingQuantity, Category, Supplier, Cost, ProfitPercentage, Tax, ListPrice, IdUser, Photo)
               VALUES (@CodigoBarras, @Name, @ExistingQuantity, @Category, @Supplier, @Cost, @ProfitPercentage, @Tax, @ListPrice, @IdUser, @Photo)";

            try
            { 
                //command.Parameters.AddWithValue("@IdProduct", pProduct.IdProduct);
                command.Parameters.AddWithValue("@CodigoBarras", pProduct.CodigoBarras);
                command.Parameters.AddWithValue("@Name", pProduct.Name);
                command.Parameters.AddWithValue("@ExistingQuantity", pProduct.ExistingQuantity);
                command.Parameters.AddWithValue("@Category", pProduct.Category.IdCategory); 
                command.Parameters.AddWithValue("@Supplier", pProduct.Supplier.IdSupplier);
                command.Parameters.AddWithValue("@Cost", pProduct.Cost);
                command.Parameters.AddWithValue("@ProfitPercentage", pProduct.ProfitPercentage);
                command.Parameters.AddWithValue("@Tax", pProduct.Tax);
                command.Parameters.AddWithValue("@ListPrice", pProduct.ListPrice);
                command.Parameters.AddWithValue("@IdUser", pProduct.User.IdUsser); 
                command.Parameters.AddWithValue("@Photo", pProduct.Photo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo

                    if (rows > 0)
                        oProduct = this.GetProductById(pProduct.IdProduct.ToString());
                }

                return oProduct;

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

        public async Task<Product> UpdateProduct(Product pProduct)
        {

            string sql = @"UPDATE Product 
               SET CodigoBarras = @CodigoBarras, 
                   Name = @Name, 
                   ExistingQuantity = @ExistingQuantity, 
                   Category = @Category, 
                   Supplier = @Supplier, 
                   Cost = @Cost, 
                   ProfitPercentage = @ProfitPercentage, 
                   Tax = @Tax, 
                   ListPrice = @ListPrice, 
                   IdUser = @IdUser, 
                   Photo = @Photo
               WHERE IdProduct = @IdProduct";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Product oProduct = new Product();
            try
            {
                command.Parameters.AddWithValue("@IdProduct", pProduct.IdProduct);
                command.Parameters.AddWithValue("@CodigoBarras", pProduct.CodigoBarras);
                command.Parameters.AddWithValue("@Name", pProduct.Name);
                command.Parameters.AddWithValue("@ExistingQuantity", pProduct.ExistingQuantity);
                command.Parameters.AddWithValue("@Category", pProduct.Category.IdCategory);
                command.Parameters.AddWithValue("@Supplier", pProduct.Supplier.IdSupplier);
                command.Parameters.AddWithValue("@Cost", pProduct.Cost);
                command.Parameters.AddWithValue("@ProfitPercentage", pProduct.ProfitPercentage);
                command.Parameters.AddWithValue("@Tax", pProduct.Tax);
                command.Parameters.AddWithValue("@ListPrice", pProduct.ListPrice);
                command.Parameters.AddWithValue("@IdUser", pProduct.User.IdUsser);
                command.Parameters.AddWithValue("@Photo", pProduct.Photo);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oProduct = this.GetProductById(pProduct.IdProduct.ToString());

                return oProduct;

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
