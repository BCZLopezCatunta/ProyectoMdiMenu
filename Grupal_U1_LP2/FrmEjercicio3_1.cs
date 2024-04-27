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
    public partial class FrmEjercicio3_1 : Form
    {
        public FrmEjercicio3_1()
        {
            InitializeComponent();
            rbtn1_1.Checked = false;
            rbtn1_2.Checked = false;
            rbtn1_3.Checked = false;
            rbtn1_4.Checked = false;
            rbtn1_5.Checked = false;
            rbtn2_1.Checked = false;
            rbtn2_2.Checked = false;
            rbtn2_3.Checked = false;
            rbtn2_4.Checked = false;
            rbtn2_5.Checked = false;
            rbtn3_1.Checked = false;
            rbtn3_2.Checked = false;
            rbtn3_3.Checked = false;
            rbtn3_4.Checked = false;
            rbtn3_5.Checked = false;
            rbtn4_1.Checked = false;
            rbtn4_2.Checked = false;
            rbtn4_3.Checked = false;
            rbtn4_4.Checked = false;
            rbtn4_5.Checked = false;

        }
        Graphics g;
        float a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, d1 = 0, d2 = 0, d3 = 0, d4 = 0, d5 = 0;
        float c = 0;
        bool f = true,f1=true;
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            rbtn1_1.Checked = false;
            rbtn1_2.Checked = false;
            rbtn1_3.Checked = false;
            rbtn1_4.Checked = false;
            rbtn1_5.Checked = false;
            rbtn2_1.Checked = false;
            rbtn2_2.Checked = false;
            rbtn2_3.Checked = false;
            rbtn2_4.Checked = false;
            rbtn2_5.Checked = false;
            rbtn3_1.Checked = false;
            rbtn3_2.Checked = false;
            rbtn3_3.Checked = false;
            rbtn3_4.Checked = false;
            rbtn3_5.Checked = false;
            rbtn4_1.Checked = false;
            rbtn4_2.Checked = false;
            rbtn4_3.Checked = false;
            rbtn4_4.Checked = false;
            rbtn4_5.Checked = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            f = true;
            f1 = true;
            if (rbtn1_1.Checked == true)
            {
                a1++;
            }
            else if (rbtn1_2.Checked == true)
            {
                a2++;
            }
            else if (rbtn1_3.Checked == true)
            {
                a3++;
            }
            else if (rbtn1_4.Checked == true)
            {
                a4++;
            }
            else if (rbtn1_5.Checked == true)
            {
                a5++;
            }
            else
            {
                if (f1)
                {
                    MessageBox.Show("Falta Rellenar Casillero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f = false;
                    f1 = false;
                }
            }

            if (rbtn2_1.Checked == true)
            {
                b1++;
            }
            else if (rbtn2_2.Checked == true)
            {
                b2++;
            }
            else if (rbtn2_3.Checked == true)
            {
                b3++;
            }
            else if (rbtn2_4.Checked == true)
            {
                b4++;
            }
            else if (rbtn2_5.Checked == true)
            {
                b5++;
            }
            else
            {
                if(f1)
                {
                    MessageBox.Show("Falta Rellenar Casillero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f = false;
                    f1 = false;
                }
            }

            if (rbtn3_1.Checked == true)
            {
                c1++;
            }
            else if (rbtn3_2.Checked == true)
            {
                c2++;
            }
            else if (rbtn3_3.Checked == true)
            {
                c3++;
            }
            else if (rbtn3_4.Checked == true)
            {
                c4++;
            }
            else if (rbtn3_5.Checked == true)
            {
                c5++;
            }
            else
            {
                if (f1)
                {
                    MessageBox.Show("Falta Rellenar Casillero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f = false;
                    f1 = false;
                }
            }

            if (rbtn4_1.Checked == true)
            {
                d1++;
            }
            else if (rbtn4_2.Checked == true)
            {
                d2++;
            }
            else if (rbtn4_3.Checked == true)
            {
                d3++;
            }
            else if (rbtn4_4.Checked == true)
            {
                d4++;
            }
            else if (rbtn4_5.Checked == true)
            {
                d5++;
            }
            else
            {
                if (f1)
                {
                    MessageBox.Show("Falta Rellenar Casillero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f = false;
                    f1 = false;
                }
            }
            if (f)
            {
                c++;
            }
            btnBorrar_Click(sender, e);
            if (c == 20)
            {
                FrmEjercicio3_2 frm = new FrmEjercicio3_2(a1, a2, a3, a4, a5, b1, b2, b3, b4, b5, c1, c2, c3, c4, c5, d1, d2, d3, d4, d5, c);
                frm.Show();
                this.Hide();
            }
        }

        


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen lapiz = new Pen(Color.Cyan, 1);
            g.DrawRectangle(lapiz, 0, 0, 974, 365);
            g.DrawLine(lapiz, 0, 74, 975, 74);
            g.DrawLine(lapiz, 0, 147, 975, 147);
            g.DrawLine(lapiz, 0, 220, 975, 220);
            g.DrawLine(lapiz, 0, 293, 975, 293);

            g.DrawLine(lapiz, 152, 0, 152, 365);
            g.DrawLine(lapiz, 220, 0, 220, 365);
            g.DrawLine(lapiz, 371, 0, 371, 365);
            g.DrawLine(lapiz, 522, 0, 522, 365);
            g.DrawLine(lapiz, 673, 0, 673, 365);
            g.DrawLine(lapiz, 824, 0, 824, 365);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen lapiz = new Pen(Color.Cyan, 1);
            g.DrawRectangle(lapiz, 0, 0, 974, 73);
            g.DrawLine(lapiz, 152, 0, 152, 73);
            g.DrawLine(lapiz, 220, 0, 220, 73);
            g.DrawLine(lapiz, 371, 0, 371, 73);
            g.DrawLine(lapiz, 522, 0, 522, 73);
            g.DrawLine(lapiz, 673, 0, 673, 73);
            g.DrawLine(lapiz, 824, 0, 824, 73);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen lapiz = new Pen(Color.Cyan, 1);
            g.DrawRectangle(lapiz, 0, 0, 974, 73);
            g.DrawLine(lapiz, 152, 0, 152, 73);
            g.DrawLine(lapiz, 220, 0, 220, 73);
            g.DrawLine(lapiz, 371, 0, 371, 73);
            g.DrawLine(lapiz, 522, 0, 522, 73);
            g.DrawLine(lapiz, 673, 0, 673, 73);
            g.DrawLine(lapiz, 824, 0, 824, 73);
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen lapiz = new Pen(Color.Cyan, 1);
            g.DrawRectangle(lapiz, 0, 0, 974, 73);
            g.DrawLine(lapiz, 152, 0, 152, 73);
            g.DrawLine(lapiz, 220, 0, 220, 73);
            g.DrawLine(lapiz, 371, 0, 371, 73);
            g.DrawLine(lapiz, 522, 0, 522, 73);
            g.DrawLine(lapiz, 673, 0, 673, 73);
            g.DrawLine(lapiz, 824, 0, 824, 73);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen lapiz = new Pen(Color.Cyan, 1);
            g.DrawRectangle(lapiz, 0, 0, 974, 73);
            g.DrawLine(lapiz, 152, 0, 152, 73);
            g.DrawLine(lapiz, 220, 0, 220, 73);
            g.DrawLine(lapiz, 371, 0, 371, 73);
            g.DrawLine(lapiz, 522, 0, 522, 73);
            g.DrawLine(lapiz, 673, 0, 673, 73);
            g.DrawLine(lapiz, 824, 0, 824, 73);
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen lapiz = new Pen(Color.Cyan, 1);
            g.DrawRectangle(lapiz, 0, 0, 974, 73);
            g.DrawLine(lapiz, 152, 0, 152, 73);
            g.DrawLine(lapiz, 220, 0, 220, 73);
            g.DrawLine(lapiz, 371, 0, 371, 73);
            g.DrawLine(lapiz, 522, 0, 522, 73);
            g.DrawLine(lapiz, 673, 0, 673, 73);
            g.DrawLine(lapiz, 824, 0, 824, 73);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//BOTON BORRAR
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
