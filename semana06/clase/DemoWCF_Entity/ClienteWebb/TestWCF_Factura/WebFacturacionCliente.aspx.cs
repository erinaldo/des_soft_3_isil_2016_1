using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestWCF_Facturas_WebFacturacionCliente : System.Web.UI.Page
{

    ProxyClientes.ClienteClient objServicioCliente = new ProxyClientes.ClienteClient();
    ProxyFacturas.ServicioFacturasClient objServicioFacturas = new ProxyFacturas.ServicioFacturasClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        try {
            if (Page.IsPostBack == false) {
                cboCliente.DataSource = objServicioCliente.ListarRazonSocialCliente();
                cboCliente.DataTextField = "RazSocCli";
                cboCliente.DataValueField = "codCli";
                cboCliente.DataBind();
            }
        }
        catch (Exception ex) {
            throw new Exception(ex.Message);
        }
    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        try {
            String strCod = cboCliente.SelectedValue.ToString();
            System.DateTime fecini = Convert.ToDateTime(txtFecini.Text);
            System.DateTime fecfin = Convert.ToDateTime(txtFecfin.Text);

            if (chkLINQ.Checked)
            {
                grvFacturas.DataSource = objServicioFacturas.GetAllFacturasClienteFechasLINQ(strCod, fecini, fecfin);
                grvFacturas.DataBind();
            }
            else {
                grvFacturas.DataSource = objServicioFacturas.GetAllFacturasClienteFechas(strCod, fecini, fecfin);
                grvFacturas.DataBind();
            }
        }
        catch (Exception ex) {
            throw new Exception(ex.Message);
        }
    }
}