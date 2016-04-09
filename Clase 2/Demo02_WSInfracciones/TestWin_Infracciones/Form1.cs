using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin_Infracciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try {
                RefAuto.WS_Auto obj_Auto = new RefAuto.WS_Auto();
                lblMulta.Text = obj_Auto.CalcularMulta(txtPlaca.Text).ToString("###.00 Nuevos Soles");
                lblPapeleta.Text = obj_Auto.AutoPropietario(txtPlaca.Text);
                ddgPapeletas.DataSource = obj_Auto.PapeletasImpagas(txtPlaca.Text).Tables[0];
            }catch (Exception ex) {
            }
        }
    }
}
