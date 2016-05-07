using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WimDemoService
{
    public partial class Form1 : Form
    {
        ProxyProductos.ServiceProductoClient srevProd = new ProxyProductos.ServiceProductoClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cboProductos.DataSource = srevProd.GetAllProducto().Tables[0];
                cboProductos.ValueMember = "cod_pro";
                cboProductos.DisplayMember = "des_pro";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnConultar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgProveedor.DataSource = srevProd.GetProveedoresProducto(cboProductos.SelectedValue.ToString()).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
