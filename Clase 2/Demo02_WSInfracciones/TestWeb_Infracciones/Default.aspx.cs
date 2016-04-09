using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConsultar_Click(object sender, EventArgs e)
    {
        try
        {
            RefAuto.WS_Auto obj_Auto = new RefAuto.WS_Auto();
            lblMulta.Text = obj_Auto.CalcularMulta(txtPlaca.Text).ToString("###.00 Nuevos Soles");
            lblPropietario.Text = obj_Auto.AutoPropietario(txtPlaca.Text);
            //ddgPapeletas.DataSource = obj_Auto.PapeletasImpagas(txtPlaca.Text).Tables[0];
        }
        catch (Exception ex)
        {
        }
    }
}