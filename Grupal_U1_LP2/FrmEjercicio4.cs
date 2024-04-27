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
    public partial class FrmEjercicio4 : Form
    {
        public FrmEjercicio4()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            dgvResultado.Rows.Clear();//Esta linea de codigo borra todas las filas del dgvResultado
            int x = 0;
            int numero = Convert.ToInt32(txtnumero.Text); //creamos la variable numero
            string numeroStr = numero.ToString();// se le asigna el valor de numero convertido a cadena de texto 
            int cantidadDigitos = numeroStr.Length;//se le asigna el valor de la cantidad de caracteres que tiene numeroStr
            cantidadDigitos = cantidadDigitos + 2;
            int[,] numeros = new int[cantidadDigitos, 3];//se crea una matriz
            numeros[0, 0] = 0;
            numeros[0, 1] = 0;
            numeros[0, 2] = 0;
            dgvResultado.Rows.Add(numeros[0, 0], numeros[0, 1], numeros[0, 2]);
            for (int i = 1; i < cantidadDigitos; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numeros[i, 0] = numero;
                    numeros[i, 1] = numero / 10;
                    numeros[i, 2] = x + 1;
                }
                if (i == cantidadDigitos - 1)
                {
                    dgvResultado.Rows.Add(numeros[i, 0] = 0, numeros[i, 1] = 0, numeros[i, 2] = 0);
                }
                else
                {
                    dgvResultado.Rows.Add(numeros[i, 0], numero + "/10=" + numeros[i, 1], x + " + 1 = " + numeros[i, 2]);
                }

                numero = numeros[i, 1];
                x = numeros[i, 2];

            }
        }
    }
}
