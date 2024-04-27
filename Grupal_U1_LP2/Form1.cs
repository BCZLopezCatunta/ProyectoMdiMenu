using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_U1_LP2
{
    public partial class Form1 : Form
    {

        //Delcarando Variables
        int deposito, retiro, monto, depositototal = 0, retirototal = 0, SaldoActual = 0;
        string cliente;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            //Limpiando las cajas de texto
            txtCliente.Text = string.Empty;
            txtDepositoCantidad.Text = string.Empty;
            txtRetiroCantidad.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtRetiroTotal.Text = string.Empty;
            txtSaldoActual.Text = string.Empty;
            txtDepositoTotal.Text = string.Empty;

            //Desmarcando los radiobotones
            rbtnDeposito.Checked = false;
            rbtnRetiro.Checked = false;
        }

        private void btnRealizarOp_Click(object sender, EventArgs e)
        {
            //Asignando valores
            cliente = Convert.ToString(txtCliente.Text);
            monto = Convert.ToInt32(txtMonto.Text);
            cliente = Convert.ToString(txtCliente.Text);

            if (rbtnDeposito.Checked == true)
            {
                deposito = monto;
                depositototal = depositototal + deposito;
                txtDepositoCantidad.Text = monto.ToString();
                MessageBox.Show(cliente + " Deposito Exitoso!!",
                        "Banco Dendif", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbtnRetiro.Checked == true)
            {
                if (monto > SaldoActual)
                {
                    MessageBox.Show(cliente + " Su saldo es insuficiente en la cuenta, ingrese monto menor o igual al saldo actual",
                        "Banco Dendif", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    retiro = monto;
                    retirototal = retirototal - retiro;
                    txtRetiroCantidad.Text = monto.ToString();
                    MessageBox.Show(cliente + " Retiro Exitoso!!",
                        "Banco Dendif", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe marcar un boton (Deposito o Retiro) para realizar una operacion...!!", "Banco Dendiff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaldoActual = depositototal + retirototal;
            txtSaldoActual.Text = Convert.ToString(SaldoActual);
            txtRetiroTotal.Text = Convert.ToString(retirototal);
            txtDepositoTotal.Text = Convert.ToString(depositototal);
        }
    }
}
