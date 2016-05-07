using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoService
{
    public partial class Form1 : Form
    {
        PrxyCliente.ServiciosClienteSoapClient servCliente = new PrxyCliente.ServiciosClienteSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                label1.Text = servCliente.GetDeudaCliente(comboBox1.SelectedValue.ToString()).toString("###,###.00 soles");
                dataGridView1.DataSource = servCliente.GetFacturasCliente(comboBox1.SelectedValue.ToString()).Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                comboBox1.DataSource = servCliente.Body().Table[0];
                comboBox1.ValueMember = "Cod_cli";
                comboBox1.DisplayMember = "Raz_soc_cli";
            }
            catch (Exception ex) {

                MessageBox.Show("Error: " +  ex.Message);
            }
        }
    }
}
