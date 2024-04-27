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
    public partial class FrmEjercicio5 : Form
    {
        public FrmEjercicio5()
        {
            InitializeComponent();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvMonedas.Rows.Clear();
            dgvBilletes.Rows.Clear();
            decimal dinero,b200,b100,b50,b20,b10,m5,m2,m1,m05,m02,m01;
            dinero=Convert.ToDecimal(txtMonto.Text);
            b200=Math.Truncate(dinero / 200);
            dinero = dinero - (200 * b200);
            dgvBilletes.Rows.Add(200, b200);
            b100 =Math.Truncate(dinero / 100);
            dinero = dinero - (100 * b100);
            dgvBilletes.Rows.Add(100, b100);
            b50 = Math.Truncate(dinero / 50);
            dinero = dinero - (50 * b50);
            dgvBilletes.Rows.Add(50, b50);
            b20 = Math.Truncate(dinero / 20);
            dinero = dinero - (20 * b20);
            dgvBilletes.Rows.Add(20, b20);
            b10 = Math.Truncate(dinero / 10);
            dinero = dinero - (10 * b10);
            dgvBilletes.Rows.Add(10, b10);
            dgvBilletes.Rows.Add("Total", b200 + b100 + b50 + b20 + b10);
            m5 = Math.Truncate(dinero / 5);
            dinero = dinero - (5 * m5);
            dgvMonedas.Rows.Add(5, m5);
            m2 = Math.Truncate(dinero / 2);
            dinero = dinero - (2 * m2);
            dgvMonedas.Rows.Add(2, m2);
            m1 = Math.Truncate(dinero / 1);
            dinero = dinero - (1 * m1);
            dgvMonedas.Rows.Add(1, m1, dinero);
            m05 = Math.Truncate(dinero*2);
            dinero = dinero - (m05/2);
            dgvMonedas.Rows.Add(0.5, m05,dinero);
            m02 = Math.Truncate(dinero*5);
            dinero = dinero - (m02/5);
            dgvMonedas.Rows.Add(0.2, m02,dinero);
            m01 = Math.Truncate(dinero*10);
            dinero = dinero - (m01/10);
            dgvMonedas.Rows.Add(0.1, m01, dinero);
            dgvMonedas.Rows.Add("Total", m5 + m2 + m1 + m05 + m02+m01);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvMonedas.Rows.Clear();
            dgvBilletes.Rows.Clear();
            txtMonto.Text = string.Empty;

        }
    }
}
