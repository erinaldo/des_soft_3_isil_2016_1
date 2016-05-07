using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de ServiciosProducto
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class ServiciosProducto : System.Web.Services.WebService
{

    public ServiciosProducto()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    String cadena = "server=.;database=VentasLeon;Integrated Security=SSPI";
    SqlConnection cnx = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    DataSet dts = new DataSet();
    SqlDataAdapter ada;

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }

    [WebMethod]
    public DataSet GetAllProducto() {
        dts.Clear();
        cnx.ConnectionString = cadena;
        cmd.Connection = cnx;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_ListarProducto";

        try {
            ada = new SqlDataAdapter(cmd);
            ada.Fill(dts,"Productos");
        }
        catch (Exception ex) {
            throw new Exception(ex.Message);
        }

        return dts;
    }

    [WebMethod]
    public DataSet GetProveedoresProducto(String strCod) {
        dts.Clear();
        cnx.ConnectionString = cadena;
        cmd.Connection = cnx;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "usp_ConsultarProductoProveedor";
        cmd.Parameters.Add(new SqlParameter("@vcodpro",SqlDbType.Char,4));
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
