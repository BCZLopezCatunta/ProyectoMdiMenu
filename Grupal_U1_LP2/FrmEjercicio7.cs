using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupal_U1_LP2
{
    public partial class FrmEjercicio7 : Form
    {
        public FrmEjercicio7()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    //Para saber la Ruta donde se ah guardado
                    lblAbrir.Text = openFileDialog.FileName;
                    txtAbrir.Text = reader.ReadToEnd();

                    //Mensaje de Alerta
                    MessageBox.Show("Se ah abierto el archivo EXITOSAMENTE ", "ARCHIVO OPEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    //Para saber la Ruta donde se ah guardado
                    lblGuardar.Text = saveFileDialog.FileName;
                    writer.Write(txtGuardar.Text);

                    //Mensaje de Alerta
                    MessageBox.Show("Se ah guardado Exitosamente ", "ARCHIVOS SALVAGUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
