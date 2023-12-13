using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Data.Common;



namespace ProyectoPromociones.Persistencia
{
    public class DataBase : IDataBase, IDisposable
    {
        public IDbConnection _Conexion { get; set; } = new SqlConnection();

        /// <summary>
        /// Ejecuta un Command y devuelve un Reader
        /// </summary>
        /// <param name="pCommand"></param>
        /// <returns></returns>
        public IDataReader ExecuteReader(IDbCommand pCommand)
        {

            IDataReader lector = null;
            try
            {
                pCommand.Connection = _Conexion;
                lector = pCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return lector;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        ///  Devuelve un DataSet a partir de un Command que hace un Select
        /// </summary>
        /// <param name="pCommand">Command con el Select</param>
        /// <param name="pTabla">Nombre de la Tabla</param>
        /// <returns></returns>
        public DataSet ExecuteReader(IDbCommand pCommand, String pTabla)
        {

            DataSet dsTabla = new DataSet();
            try
            {
                using (SqlDataAdapter adaptador = new SqlDataAdapter(pCommand as SqlCommand))
                {
                    pCommand.Connection = _Conexion;
                    dsTabla = new DataSet();
                    adaptador.Fill(dsTabla, pTabla);
                }
                return dsTabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (dsTabla != null)
                    dsTabla.Dispose();
            }

        }


        /// <summary>
        /// Utilizado para Insert, Update y Delete
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <param name="pIsolationLevel">Isolation Level ReadCommitted | ReadUncommitted | Serializable | Chaos </param>
        /// <returns>Registros afectados</returns>
        public double ExecuteNonQuery(IDbCommand pCommand, IsolationLevel pIsolationLevel)
        {
            using (IDbTransaction transaccion = _Conexion.BeginTransaction(pIsolationLevel))
            {
                double registrosafectados = 0;
                try
                {
                    pCommand.Connection = _Conexion;
                    pCommand.Transaction = transaccion;
                    registrosafectados = pCommand.ExecuteNonQuery();

                    // Commit a la transacción
                    transaccion.Commit();

                    return registrosafectados;
                }

                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// Ejecuta una Sentencia SQL pero sin transaccion, se utiliza para Alter, Create, Drop entre otros
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <returns>Filas afectadas</returns>
        public double ExecuteNonQuery(IDbCommand pCommand)
        {

            double registrosafectados = 0;
            try
            {
                pCommand.Connection = _Conexion;
                registrosafectados = pCommand.ExecuteNonQuery();
                return registrosafectados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Ejecuta un Escalar Count, AVG, MIN, Max
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <returns>valor de resultado del escalar</returns>
        public double ExecuteScalar(IDbCommand pCommand)
        {
            double registrosafectados = 0;
            object respuesta = null;
            try
            {
                pCommand.Connection = _Conexion;
                respuesta = pCommand.ExecuteScalar();
                if (respuesta == null)
                    registrosafectados = 0d;
                else
                    double.TryParse(respuesta.ToString(), out registrosafectados);

                return registrosafectados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Utilizado para Insert, Update y Delete, retorna el objeto Command Afectado que algunas vez se puede leer respuestas de los Stored Procedures
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <param name="pIsolationLevel">Isolation Level ReadCommitted | ReadUncommitted | Serializable | Chaos </param>
        /// <returns>Registros afectados</returns>
        public int ExecuteNonQuery(ref IDbCommand pCommand, IsolationLevel pIsolationLevel)
        {
            int registrosafectados = 0;
            using (IDbTransaction transaccion = _Conexion.BeginTransaction(pIsolationLevel))
            {
                try
                {
                    pCommand.Connection = _Conexion;
                    pCommand.Transaction = transaccion;
                    registrosafectados = pCommand.ExecuteNonQuery();

                    // Commit a la transacción
                    transaccion.Commit();
                    return registrosafectados;
                }
                catch (Exception error)
                {

                    throw error;
                }
            }
        }

        /// <summary>
        /// Utilizado para Insert, Update y Delete
        /// </summary>
        /// <param name="pCommands">List<T> de Commands</param>
        /// <param name="pIsolationLevel">Isolation Level ReadCommitted | ReadUncommitted | Serializable | Chaos </param>
        /// <returns>int Rows affected</returns>
        public int ExecuteNonQuery(List<IDbCommand> pCommands, IsolationLevel pIsolationLevel)
        {
            int registrosafectados = 0;
            try
            {
                using (IDbTransaction transaccion = _Conexion.BeginTransaction(pIsolationLevel))
                {
                    foreach (IDbCommand command in pCommands)
                    {
                        command.Connection = (_Conexion as SqlConnection);
                        command.Transaction = transaccion;
                        registrosafectados = command.ExecuteNonQuery();
                    }
                    // Commit a la transacción
                    transaccion.Commit();
                }
                return registrosafectados;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }

        }

        /// <summary>
        /// Ejecuta un Command y devuelve un SqlDataReader
        /// </summary>
        /// <param name="pCommand"></param>
        /// <returns> Task<SqlDataReader></returns>
        public async Task<SqlDataReader> ExecuteReaderAsync(SqlCommand pCommand)
        {
            try
            {
                pCommand.Connection = _Conexion as SqlConnection;
                return await pCommand.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Retorna Task<DataTable>
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <returns>Task<DataTable><SqlDataReader></returns>
        public async Task<DataTable> ExecuteReaderAsync(SqlCommand pCommand, String pTabla)
        {
            DbDataReader dr = null;
            DataTable dataTable = new DataTable(pTabla);
            try
            {
                pCommand.Connection = _Conexion as SqlConnection;
                dr = await pCommand.ExecuteReaderAsync(CommandBehavior.Default);
                dataTable.Load(dr);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Utilizado para Insert, Update y Delete de forma Async
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <param name="pIsolationLevel">Isolation Level ReadCommitted | ReadUncommitted | Serializable | Chaos </param>
        /// <returns>Task<int> Registros afectados</returns>
        public async Task<int> ExecuteNonQueryAsync(SqlCommand pCommand, IsolationLevel pIsolationLevel)
        {
            using (IDbTransaction transaccion = _Conexion.BeginTransaction(pIsolationLevel))
            {
                // double registrosafectados = 0;
                try
                {
                    pCommand.Connection = _Conexion as SqlConnection;
                    pCommand.Transaction = transaccion as SqlTransaction;

                    Task<int> task = pCommand.ExecuteNonQueryAsync();

                    // Espera para realizar la transacción
                    if (task.Wait(pCommand.CommandTimeout * 1000) == false)
                    {
                        throw new Exception("No se pudo Salvar el Registro, CommandTimeout");
                    }
                    // Commit a la transacción
                    transaccion.Commit();
                    return await task;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// Ejecuta un Escalar Count, AVG, MIN, Max de forma Scalar
        /// </summary>
        /// <param name="pCommand">Command</param>
        /// <returns> Task<double></returns>
        public async Task<double> ExecuteScalarAsync(SqlCommand pCommand)
        {
            double registrosafectados = 0;
            try
            {
                pCommand.Connection = _Conexion as SqlConnection;
                var task = await pCommand.ExecuteScalarAsync();
                if (task == null)
                    registrosafectados = 0d;
                else
                    double.TryParse(task.ToString(), out registrosafectados);

                return registrosafectados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Destruye la conexion
        /// </summary>
        public void Dispose()
        {
            if (_Conexion != null)
                _Conexion.Close();
        }
    }
}