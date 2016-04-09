using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLINQ
{
    public partial class Test1 : Form
    {

        VentasLeonDataContext misVentas = new VentasLeonDataContext();

        public Test1()
        {
            InitializeComponent();
        }

        private void Test1_Load(object sender, EventArgs e)
        {
            try {
                var query = from objDistrito in misVentas.Tb_Distrito orderby objDistrito.Nom_dis select objDistrito;

                cbDistritos.DataSource = query;
                cbDistritos.DisplayMember = "Nom_dis";
                cbDistritos.ValueMember = "Cod_dis";
            }
            catch (Exception ex) {
                MessageBox.Show("Error: ..." + ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try {
                var sql = from miCliente in misVentas.Tb_Cliente
                          where miCliente.Cod_dis == cbDistritos.SelectedValue.ToString()
                          select new { Codigo = miCliente.Cod_cli, RS = miCliente.Raz_soc_cli, Direccion = miCliente.Dir_cli };

                ddgClientes.DataSource = sql;
            }
            catch (Exception ex) {
            }
        }
    }
}
