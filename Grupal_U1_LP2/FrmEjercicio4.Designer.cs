namespace Grupal_U1_LP2
{
    partial class FrmEjercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiv10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contador de digitos - Ejercicio4";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(293, 73);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 23);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(187, 75);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 9;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColDiv10,
            this.ColSCD});
            this.dgvResultado.Location = new System.Drawing.Point(45, 112);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(343, 228);
            this.dgvResultado.TabIndex = 8;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "Numero n";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            // 
            // ColDiv10
            // 
            this.ColDiv10.HeaderText = "Dividiendo entre 10";
            this.ColDiv10.Name = "ColDiv10";
            this.ColDiv10.ReadOnly = true;
            // 
            // ColSCD
            // 
            this.ColSCD.HeaderText = "Suma cantidad de digitos ";
            this.ColSCD.Name = "ColSCD";
            this.ColSCD.ReadOnly = true;
            // 
            // FrmEjercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.dgvResultado);
            this.Name = "FrmEjercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjercicio4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiv10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSCD;
    }
}