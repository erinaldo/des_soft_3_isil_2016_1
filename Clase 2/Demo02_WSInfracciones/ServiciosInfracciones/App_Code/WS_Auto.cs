using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de WS_Auto
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WS_Auto : System.Web.Services.WebService
{

    public WS_Auto()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    String cadena = "server=.;database=infracciones;Integrated Security=SSPI";
    SqlConnection cnx = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    DataSet dts = new DataSet();
    SqlDataAdapter ada = new SqlDataAdapter();

    [WebMethod]
    public Single CalcularMulta(String strNumPlaca) {
        Single vmulta;
        try {
            cnx.ConnectionString = cadena;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_AutoMulta";
            cmd.Parameters.Add(new SqlParameter("@num_placa",SqlDbType.Char,8));
            cmd.Parameters["@num_placa"].Value = strNumPlaca;
            cmd.Parameters.Add(new SqlParameter("@multa",SqlDbType.Money));
            cmd.Parameters["@multa"].Direction = ParameterDirection.Output;
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            vmulta = Convert.ToSingle(cmd.Parameters["@multa"].Value);
        }
        catch (SqlException ex) {
            throw new Exception(ex.Message);
        }
        return vmulta;
    }

    [WebMethod]
    public String AutoPropietario(String strNumPlaca)
    {
        String vmulta;
        try
        {
            cnx.ConnectionString = cadena;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_AutoPropietario";
            cmd.Parameters.Add(new SqlParameter("@num_placa", SqlDbType.Char, 8));
            cmd.Parameters["@num_placa"].Value = strNumPlaca;
            cmd.Parameters.Add(new SqlParameter("@datos", SqlDbType.VarChar,80));
            cmd.Parameters["@datos"].Direction = ParameterDirection.Output;
            cnx.Open();
            cmd.ExecuteScalar();
            cnx.Close();
            vmulta = cmd.Parameters["@datos"].Value.ToString();
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        return vmulta;
    }

    [WebMethod]
    public DataSet PapeletasImpagas(String strNumPlaca)
    {
        try
        {
            dts.Clear();
            cnx.ConnectionString = cadena;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_PapeletasImpagas";
            cmd.Parameters.Add(new SqlParameter("@num_placa", SqlDbType.Char, 8));
            cmd.Parameters["@num_placa"].Value = strNumPlaca;
            ada = new SqlDataAdapter(cmd);
            ada.Fill(dts, "PapeletasImpagas");
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }
        return dts;
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hola a todos";
    }

}
