using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace WCFTestCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            String codigo1 = txtClienteUno.Text;
            String codigo2 = txtClienteDos.Text;
            Single monto = Convert.ToSingle(txtMonto.Text);

            Proxy.SaldoCliente saldoCliente = new Proxy.SaldoCliente();
            Proxy2.SaldoCliente saldoCliente2 = new Proxy2.SaldoCliente();

            saldoCliente.Cliente = codigo1;
            saldoCliente.Saldo = monto;

            saldoCliente2.Cliente = codigo2;
            saldoCliente2.Saldo = monto;

            using (TransactionScope tx = new TransactionScope()) {
                try {
                    Proxy.Service1Client servicio1 = new Proxy.Service1Client();
                    Single fila1 = servicio1.RestarSaldo(saldoCliente);

                    Proxy2.Service1Client servicio2 = new Proxy2.Service1Client();
                    Single fila2 = servicio2.SumarSaldo(saldoCliente2);

                    if (fila1 <= 0 | fila2 <= 0)
                    {
                        tx.Dispose();
                        MessageBox.Show("Código de cliente no existe o saldo insuficiente", "Ok");
                    }
                    else {
                        tx.Complete();
                        MessageBox.Show("Transacción Satisfactoria!", "Ok");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error" + ex.Message, "Error");
                }
            }

        }
    }
}
