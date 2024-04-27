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
    public partial class MDIPrincipal : Form
    {
      
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuEjercicio1_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 1
            Form1 Frm1 = new Form1();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void mnuEjercicio2_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 2
            FrmEjercicio2 Frm2 = new FrmEjercicio2();
            Frm2.MdiParent = this;
            Frm2.Show();
        }

        private void mnuEjercicio3_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 3
            FrmEjercicio3_1 Frm3 = new FrmEjercicio3_1();
            Frm3.MdiParent = this;
            Frm3.Show();
        }

        private void mnuEjercicio4_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 4
            FrmEjercicio4 Frm4 = new FrmEjercicio4();
            Frm4.MdiParent = this;
            Frm4.Show();
        }

        private void mnuEjercicio5_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 5
            FrmEjercicio5 Frm5 = new FrmEjercicio5();
            Frm5.MdiParent = this;
            Frm5.Show();
        }

        private void mnuEjercicio6_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 6
            FrmEjercicio6 Frm6 = new FrmEjercicio6();
            Frm6.MdiParent = this;
            Frm6.Show();
        }

        private void mnuEjercicio7_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 7
            FrmEjercicio7 Frm7 = new FrmEjercicio7();
            Frm7.MdiParent = this;
            Frm7.Show();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 1
            Form1 Frm1 = new Form1();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 2
            FrmEjercicio2 Frm2 = new FrmEjercicio2();
            Frm2.MdiParent = this;
            Frm2.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 3
            FrmEjercicio3_1 Frm3 = new FrmEjercicio3_1();
            Frm3.MdiParent = this;
            Frm3.Show();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 4
            FrmEjercicio4 Frm4 = new FrmEjercicio4();
            Frm4.MdiParent = this;
            Frm4.Show();
        }

        private void btnEjercicio5_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 5
            FrmEjercicio5 Frm5 = new FrmEjercicio5();
            Frm5.MdiParent = this;
            Frm5.Show();
        }

        private void btnEjercicio6_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 6
            FrmEjercicio6 Frm6 = new FrmEjercicio6();
            Frm6.MdiParent = this;
            Frm6.Show();
        }

        private void btnEjercicio7_Click(object sender, EventArgs e)
        {
            //Intanciar la clase formulario 7
            FrmEjercicio7 Frm7 = new FrmEjercicio7();
            Frm7.MdiParent = this;
            Frm7.Show();
        }
    }
}
