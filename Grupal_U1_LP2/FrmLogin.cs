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
    public partial class FrmLogin : Form
    {
        //Declarando Variables globales
        string Usuario = "epis", Password = "epis";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            pgbEstado.Value = pgbEstado.Value + 5;
            if (pgbEstado.Value >= 100)
            {
                MDIPrincipal principal = new MDIPrincipal();
                principal.Show();
                this.Hide();
                Tiempo.Enabled = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Definiendo variables
            String usu, pass;
            usu = txtUsuario.Text;
            pass = txtPassword.Text;

            if ((usu.Equals(Usuario)) && (pass.Equals(Password)))
            {
                MessageBox.Show("Bienvenido al Sistema " + Usuario,
                    "Login de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Tiempo.Enabled = true;

                //MDIPrincipal principal = new MDIPrincipal();
                //principal.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Password incorrectos..!!",
                    "Login de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
