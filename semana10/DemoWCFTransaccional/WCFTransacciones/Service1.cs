using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WCFTransacciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public Single RestarSaldo(SaldoCliente saldo)
        {
            SqlParameter parametro;
            int filasAfectadas;
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["BDEMPRESA1"].ConnectionString;

            try {
                SqlCommand comando = new SqlCommand("usp_RestarSaldoCliente", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                parametro = new SqlParameter("@Codigo", SqlDbType.Char, 3);
                parametro.Direction = ParameterDirection.Input;
                parametro.Value = saldo.Cliente;
                comando.Parameters.Add(parametro);

                parametro = new SqlParameter("@Monto", SqlDbType.Money);
                parametro.Direction = ParameterDirection.Input;
                parametro.Value = saldo.Saldo;
                comando.Parameters.Add(parametro);

                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally{
                if (conexion.State == ConnectionState.Open) {
                    conexion.Close();
                }
            }

            return filasAfectadas;

        }
    }
}
