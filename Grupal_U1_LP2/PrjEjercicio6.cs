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
    public partial class PrjEjercicio6 : Form
    {
        public PrjEjercicio6()
        {
            InitializeComponent();
        }
        Graphics g;
        private void pcbGrafico_Paint(object sender, PaintEventArgs e)
        {
            int y;
            g=e.Graphics;//203,358
            Pen lapiz = new Pen(Color.Black, 1);
            g.DrawRectangle(lapiz, 0, 0, 202, 357);
            g.DrawLine(lapiz, 102, 22, 203, 22);
            g.DrawLine(lapiz, 102, 0, 102, 358);
            y = 22;
            for (int i = 0; i < 15; i++)
            {
                y += 21;
                g.DrawLine(lapiz, 0, y, 203, y);   
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt001.Text = string.Empty;
            txt005.Text = string.Empty;
            txt01.Text = string.Empty;
            txt02.Text = string.Empty;
            txt05.Text  = string.Empty;
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
            txt5.Text = string.Empty;
            txt10.Text = string.Empty;
            txt20.Text = string.Empty;
            txt50.Text = string.Empty;
            txt100.Text = string.Empty;
            txt200.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtTotalB.Text = string.Empty;
            txtTotalM.Text = string.Empty;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            decimal  b200, b100, b50, b20, b10, m5, m2, m1, m05, m02, m01,m005,m001;
            decimal totalB,totalM,total;
            b200 = Convert.ToDecimal(txt200.Text);
            b100 = Convert.ToDecimal(txt100.Text);
            b50 = Convert.ToDecimal(txt50.Text);
            b20 = Convert.ToDecimal(txt20.Text);
            b10 = Convert.ToDecimal(txt10.Text);
            m5 = Convert.ToDecimal(txt5.Text);
            m2 = Convert.ToDecimal(txt2.Text);
            m1 = Convert.ToDecimal(txt1.Text);
            m05 = Convert.ToDecimal(txt05.Text);
            m02 = Convert.ToDecimal(txt02.Text);
            m01 = Convert.ToDecimal(txt01.Text);
            m005 = Convert.ToDecimal(txt005.Text);
            m001 = Convert.ToDecimal(txt001.Text);
            if (b200 % 200 == 0 && b100 % 100 == 0 && b50%50==0 && b20%20== 0 && b10 % 10 == 0 && m5 % 5 == 0 && m2 % 2 == 0 && m1 % 1 == 0 && m05*2 % 1 == 0 && m02*5 % 1 == 0 && m01*10 % 1 == 0 && m005*20 % 1 == 0 && m001*100 % 1 == 0)
            {
                totalB = b200 + b100 + b50 + b20 + b10;
                totalM = m5 + m2 + m1 + m05 + m02 + m01 + m005 + m001;
                total = totalB + totalM;
                txtTotalB.Text=Convert.ToString(totalB);
                txtTotalM.Text = Convert.ToString(totalM);
                txtTotal.Text= Convert.ToString(total);
            }
            else
            {
                MessageBox.Show("Dato Ingresado Erroneo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
