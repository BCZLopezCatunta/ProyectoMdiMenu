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
    public partial class FrmEjercicio6 : Form
    {
        public FrmEjercicio6()
        {
            InitializeComponent();
            txtBillete10.Text = "0";
            txtBillete100.Text = "0";
            txtBillete20.Text = "0";
            txtBillete200.Text = "0";
            txtBillete50.Text = "0";
            txtMoneda1.Text = "0";
            txtMoneda2.Text = "0";
            txtMoneda3.Text = "0";
            txtMoneda4.Text = "0";
            txtMoneda5.Text = "0";
            txtMoneda6.Text = "0";
            txtMoneda7.Text = "0";
            txtMoneda8.Text = "0";
            lblResultado.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiando caja de texto Billetes
            txtBillete10.Text = "0";
            txtBillete100.Text = "0";
            txtBillete20.Text = "0";
            txtBillete200.Text = "0";
            txtBillete50.Text = "0";

            //Limpiando caja de texto Monedas
            txtMoneda1.Text = "0";
            txtMoneda2.Text = "0";
            txtMoneda3.Text = "0";
            txtMoneda4.Text = "0";
            txtMoneda5.Text = "0";
            txtMoneda6.Text = "0";
            txtMoneda7.Text = "0";
            txtMoneda8.Text = "0";

            //Limpiando cajas de Total
            txtTotal.Text = string.Empty;
            txtTotalBilletes.Text = string.Empty;
            txtTotalMonedas.Text = string.Empty;

            lblResultado.Text = "";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Declarando variables
            decimal B10 = 0, B20 = 0, B50 = 0, B100 = 0, B200 = 0, Totalbilletes = 0;
            decimal M5 = 0, M2 = 0, M1 = 0, M50 = 0, M20 = 0, M10 = 0, M05 = 0, M01 = 0, Totalmonedas = 0, Total = 0;
            //Asignando valores

            B10 = Convert.ToDecimal(txtBillete10.Text);
            B20 = Convert.ToDecimal(txtBillete20.Text);
            B50 = Convert.ToDecimal(txtBillete50.Text);
            B100 = Convert.ToDecimal(txtBillete100.Text);
            B200 = Convert.ToDecimal(txtBillete200.Text);

            M5 = Convert.ToDecimal(txtMoneda1.Text);
            M2 = Convert.ToDecimal(txtMoneda2.Text);
            M1 = Convert.ToDecimal(txtMoneda3.Text);
            M50 = Convert.ToDecimal(txtMoneda4.Text);
            M20 = Convert.ToDecimal(txtMoneda5.Text);
            M10 = Convert.ToDecimal(txtMoneda6.Text);
            M05 = Convert.ToDecimal(txtMoneda7.Text);
            M01 = Convert.ToDecimal(txtMoneda8.Text);

            //Operando
            if (B200 % 200 == 0)
            {
                if (B100 % 100 == 0)
                {
                    if (B50 % 50 == 0)
                    {
                        if (B20 % 20 == 0)
                        {
                            if (B10 % 10 == 0)
                            {
                                Totalbilletes = B200 + B100 + B50 + B20 + B10;
                                txtTotalBilletes.Text = Totalbilletes.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Denominacion incorrecta para los billetes de 10..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Denominacion incorrecta para los billetes de 20..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Denominacion incorrecta para los billetes de 50..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Denominacion incorrecta para los billetes de 100..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Denominacion incorrecta para los billetes de 200..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (M5 % 5 == 0)
            {
                if (M2 % 2 == 0)
                {
                    if (M1 % 1 == 0)
                    {
                        if (M50 * 10 % 5 == 0)
                        {
                            if (M20 * 10 % 2 == 0)
                            {
                                if (M10 * 10 % 1 == 0)
                                {
                                    if (M05 * 100 % 5 == 0)
                                    {
                                        if (M01 * 100 % 1 == 0)
                                        {
                                            Totalmonedas = M5 + M2 + M1 + M50 + M20 + M10 + M05 + M01;
                                            txtTotalMonedas.Text = Totalmonedas.ToString();

                                            Total = Totalbilletes + Totalmonedas;
                                            txtTotal.Text = Total.ToString();
                                            lblResultado.Text = Conversion.NumeroALetras(Total) + " NUEVOS SOLES";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Denominacion incorrecta para la moneda de 0,01 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Denominacion incorrecta para la moneda de 0,05 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Denominacion incorrecta para la moneda de 0,10 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Denominacion incorrecta para la moneda de 0,20 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Denominacion incorrecta para la moneda de 0,50 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Denominacion incorrecta para la moneda de 1,00 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Denominacion incorrecta para la moneda de 2,00 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Denominacion incorrecta para la moneda de 5,00 ..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
