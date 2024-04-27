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
    public partial class FrmEjercicio2 : Form
    {
        //Declarando las variables Globales
        int Segundos = 0;
        int Minutos = 0;
        public FrmEjercicio2()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia
            txtResultado1.Clear();
            txtResultado2.Clear();
            txtResultado3.Clear();
            txtResultado4.Clear();

            rdb58.Checked = false;
            rdb34.Checked = false;
            rdb31.Checked = false;
            rdb40.Checked = false;

            rdbMarte.Checked = false;
            rdbJupiter.Checked = false;
            rdbTierra.Checked = false;
            rdbSaturno.Checked = false;

            rdbola.Checked = false;
            rdbdecision.Checked = false;
            rdbhay.Checked = false;
            rdbahi.Checked = false;

            chkSagaz.Checked = false;
            chkListo.Checked = false;
            chkLerdo.Checked = false;
            chkAstuto.Checked = false;

            txtCorrectas.Clear();
            txtIncorrectas.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Declarando las variables
            int correctas = 0;
            int incorrectas = 0;


            //Condicionales
            if (rdb31.Checked)
            {
                txtResultado1.ForeColor = System.Drawing.Color.Blue;
                txtResultado1.Text = "CORRECTO";
                correctas = correctas + 1;
            }
            else
            {
                txtResultado1.ForeColor = System.Drawing.Color.Red;
                txtResultado1.Text = "INCORRECTO";
                incorrectas = incorrectas + 1;
            }
            if (rdbJupiter.Checked)
            {
                txtResultado2.ForeColor = System.Drawing.Color.Blue;
                txtResultado2.Text = "CORRECTO";
                correctas = correctas + 1;
            }
            else
            {
                txtResultado2.ForeColor = System.Drawing.Color.Red;
                txtResultado2.Text = "INCORRECTO";
                incorrectas = incorrectas + 1;
            }
            if (rdbdecision.Checked)
            {
                txtResultado3.ForeColor = System.Drawing.Color.Blue;
                txtResultado3.Text = "CORRECTO";
                correctas = correctas + 1;
            }
            else
            {
                txtResultado3.ForeColor = System.Drawing.Color.Red;
                txtResultado3.Text = "INCORRECTO";
                incorrectas = incorrectas + 1;
            }
            if (chkListo.Checked)
            {
                txtResultado4.ForeColor = System.Drawing.Color.Blue;
                txtResultado4.Text = "CORRECTO";
                correctas = correctas + 1;
            }
            else
            {
                txtResultado4.ForeColor = System.Drawing.Color.Red;
                txtResultado4.Text = "INCORRECTO";
                incorrectas = incorrectas + 1;
            }

            txtCorrectas.Text = Convert.ToString(correctas);
            txtIncorrectas.Text = Convert.ToString(incorrectas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Segundos = Segundos + 1;
            lblSegundos.Text = Convert.ToString(Segundos);

            if (Segundos == 60)
            {
                Segundos = 0;
                Minutos = Minutos + 1;
                lblMinutos.Text = Convert.ToString(Minutos);
            }

            if (Minutos == 3)
            {
                this.Hide();
            }
        }

        private void FrmEjercicio2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
