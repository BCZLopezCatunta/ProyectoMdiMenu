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
    public partial class FrmEjercicio3_2 : Form
    {
        private float a1, a2, a3, a4, a5, b1, b2, b3, b4, b5, c1, c2, c3, c4, c5, d1, d2, d3, d4, d5, c;

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        public FrmEjercicio3_2(float a1, float a2, float a3, float a4, float a5, float b1, float b2, float b3, float b4, float b5, float c1, float c2, float c3, float c4, float c5, float d1, float d2, float d3, float d4, float d5, float c)
        {
            InitializeComponent();
            double A, B, C, D;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.a5 = a5;
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.b4 = b4;
            this.b5 = b5;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.c4 = c4;
            this.c5 = c5;
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.d4 = d4;
            this.d5 = d5;
            this.c5 = d5;
            dgvResultado.Rows.Add("Frente\r\nUnitario\r\nPopular", a1 + "(" + (a1 / c) * 100 + "%)", a2 + "(" + (a2 / c) * 100 + "%)", a3 + "(" + (a3 / c) * 100 + "%)", a4 + "(" + (a4 / c) * 100 + "%)", a5 + "(" + (a5 / c) * 100 + "%)", c, 100);
            dgvResultado.Rows.Add("Siempre\r\nTacna", b1 + "(" + (b1 / c) * 100 + "%)", b2 + "(" + (b2 / c) * 100 + "%)", b3 + "(" + (b3 / c) * 100 + "%)", b4 + "(" + (b4 / c) * 100 + "%)", b5 + "(" + (b5 / c) * 100 + "%)", c, 100);
            dgvResultado.Rows.Add("Perú Patria\r\nSegura", c1 + "(" + (c1 / c) * 100 + "%)", c2 + "(" + (c2 / c) * 100 + "%)", c3 + "(" + (c3 / c) * 100 + "%)", c4 + "(" + (c4 / c) * 100 + "%)", c5 + "(" + (c5 / c) * 100 + "%)", c, 100);
            dgvResultado.Rows.Add("Frente\r\nAmplio", d1 + "(" + (d1 / c) * 100 + "%)", d2 + "(" + (d2 / c) * 100 + "%)", d3 + "(" + (d3 / c) * 100 + "%)", d4 + "(" + (d4 / c) * 100 + "%)", d5 + "(" + (d5 / c) * 100 + "%)", c, 100);

            A = Math.Round(((c * 100) / c), 2);
            B = Math.Round(((c * 100) / c), 2);
            C = Math.Round(((c * 100) / c), 2);
            D = Math.Round(((c * 100) / c), 2);

            progressBar1.Value = Convert.ToInt32(A);
            progressBar2.Value = Convert.ToInt32(B);
            progressBar3.Value = Convert.ToInt32(C);
            progressBar4.Value = Convert.ToInt32(D);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
