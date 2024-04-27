namespace Grupal_U1_LP2
{
    partial class FrmEjercicio5
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dgvBilletes = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMonedas = new System.Windows.Forms.DataGridView();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(124, 58);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(227, 22);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Ejemplo: Monto a Retirar:";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(376, 58);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // dgvBilletes
            // 
            this.dgvBilletes.AllowUserToAddRows = false;
            this.dgvBilletes.AllowUserToDeleteRows = false;
            this.dgvBilletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.dgvBilletes.Location = new System.Drawing.Point(112, 112);
            this.dgvBilletes.Name = "dgvBilletes";
            this.dgvBilletes.ReadOnly = true;
            this.dgvBilletes.Size = new System.Drawing.Size(240, 221);
            this.dgvBilletes.TabIndex = 2;
            // 
            // col1
            // 
            this.col1.HeaderText = "Denominacion de Billetes";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.HeaderText = "Cantidad";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // dgvMonedas
            // 
            this.dgvMonedas.AllowUserToAddRows = false;
            this.dgvMonedas.AllowUserToDeleteRows = false;
            this.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col3,
            this.col4});
            this.dgvMonedas.Location = new System.Drawing.Point(379, 112);
            this.dgvMonedas.Name = "dgvMonedas";
            this.dgvMonedas.ReadOnly = true;
            this.dgvMonedas.Size = new System.Drawing.Size(240, 221);
            this.dgvMonedas.TabIndex = 3;
            // 
            // col3
            // 
            this.col3.HeaderText = "Denominacion de Monedas";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.HeaderText = "Cantidad";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(518, 34);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(518, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmEjercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvMonedas);
            this.Controls.Add(this.dgvBilletes);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblText);
            this.Name = "FrmEjercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjercicio5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DataGridView dgvBilletes;
        private System.Windows.Forms.DataGridView dgvMonedas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
    }
}