using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DemoServiceVentas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServiceProducto : IServiceProducto
    {
        public DataSet GetAllProducto()
        {
            String cadena = "server=.;database=VentasLeon;Integrated Security=SSPI";
            SqlConnection cnx = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataSet dts = new DataSet();
            SqlDataAdapter ada;

            dts.Clear();
            cnx.ConnectionString = cadena;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarProducto";

            try
            {
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Productos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dts;

        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public DataSet GetProveedoresProducto(string strCod)
        {
            String cadena = "server=.;database=VentasLeon;Integrated Security=SSPI";
            SqlConnection cnx = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataSet dts = new DataSet();
            SqlDataAdapter ada;

            dts.Clear();
            cnx.ConnectionString = cadena;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarProductoProveedor";
            cmd.Parameters.Add(new SqlParameter("@vcodpro", SqlDbType.Char, 4));
            cmd.Parameters["@vcodpro"].Value = strCod;

            try
            {
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ProductosProveedor");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dts;

        }
    }
}
