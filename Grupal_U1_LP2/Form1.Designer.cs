namespace Grupal_U1_LP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnRetiro = new System.Windows.Forms.RadioButton();
            this.rbtnDeposito = new System.Windows.Forms.RadioButton();
            this.btnRealizarOp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.txtRetiroTotal = new System.Windows.Forms.TextBox();
            this.txtRetiroCantidad = new System.Windows.Forms.TextBox();
            this.txtDepositoTotal = new System.Windows.Forms.TextBox();
            this.txtDepositoCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(147, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Bancarias";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(502, 287);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(502, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMonto.Location = new System.Drawing.Point(89, 57);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCliente.Location = new System.Drawing.Point(89, 28);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(325, 20);
            this.txtCliente.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.rbtnRetiro);
            this.groupBox2.Controls.Add(this.rbtnDeposito);
            this.groupBox2.Controls.Add(this.btnRealizarOp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSaldoActual);
            this.groupBox2.Controls.Add(this.txtRetiroTotal);
            this.groupBox2.Controls.Add(this.txtRetiroCantidad);
            this.groupBox2.Controls.Add(this.txtDepositoTotal);
            this.groupBox2.Controls.Add(this.txtDepositoCantidad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(29, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 182);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacciones";
            // 
            // rbtnRetiro
            // 
            this.rbtnRetiro.AutoSize = true;
            this.rbtnRetiro.Location = new System.Drawing.Point(194, 39);
            this.rbtnRetiro.Name = "rbtnRetiro";
            this.rbtnRetiro.Size = new System.Drawing.Size(53, 17);
            this.rbtnRetiro.TabIndex = 18;
            this.rbtnRetiro.TabStop = true;
            this.rbtnRetiro.Text = "Retiro";
            this.rbtnRetiro.UseVisualStyleBackColor = true;
            // 
            // rbtnDeposito
            // 
            this.rbtnDeposito.AutoSize = true;
            this.rbtnDeposito.Location = new System.Drawing.Point(121, 39);
            this.rbtnDeposito.Name = "rbtnDeposito";
            this.rbtnDeposito.Size = new System.Drawing.Size(67, 17);
            this.rbtnDeposito.TabIndex = 17;
            this.rbtnDeposito.TabStop = true;
            this.rbtnDeposito.Text = "Deposito";
            this.rbtnDeposito.UseVisualStyleBackColor = true;
            // 
            // btnRealizarOp
            // 
            this.btnRealizarOp.Location = new System.Drawing.Point(320, 43);
            this.btnRealizarOp.Name = "btnRealizarOp";
            this.btnRealizarOp.Size = new System.Drawing.Size(123, 23);
            this.btnRealizarOp.TabIndex = 5;
            this.btnRealizarOp.Text = "Realizar Operacion";
            this.btnRealizarOp.UseVisualStyleBackColor = true;
            this.btnRealizarOp.Click += new System.EventHandler(this.btnRealizarOp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(340, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "SALDO ACTUAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(205, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "TOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(99, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CANTIDAD";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSaldoActual.Location = new System.Drawing.Point(340, 114);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoActual.TabIndex = 13;
            // 
            // txtRetiroTotal
            // 
            this.txtRetiroTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtRetiroTotal.Location = new System.Drawing.Point(194, 114);
            this.txtRetiroTotal.Name = "txtRetiroTotal";
            this.txtRetiroTotal.Size = new System.Drawing.Size(100, 20);
            this.txtRetiroTotal.TabIndex = 12;
            // 
            // txtRetiroCantidad
            // 
            this.txtRetiroCantidad.BackColor = System.Drawing.SystemColors.Info;
            this.txtRetiroCantidad.Location = new System.Drawing.Point(83, 114);
            this.txtRetiroCantidad.Name = "txtRetiroCantidad";
            this.txtRetiroCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtRetiroCantidad.TabIndex = 11;
            // 
            // txtDepositoTotal
            // 
            this.txtDepositoTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtDepositoTotal.Location = new System.Drawing.Point(194, 87);
            this.txtDepositoTotal.Name = "txtDepositoTotal";
            this.txtDepositoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtDepositoTotal.TabIndex = 10;
            // 
            // txtDepositoCantidad
            // 
            this.txtDepositoCantidad.BackColor = System.Drawing.SystemColors.Info;
            this.txtDepositoCantidad.Location = new System.Drawing.Point(83, 87);
            this.txtDepositoCantidad.Name = "txtDepositoCantidad";
            this.txtDepositoCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtDepositoCantidad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Retiro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deposito :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operaciones:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnRetiro;
        private System.Windows.Forms.RadioButton rbtnDeposito;
        private System.Windows.Forms.Button btnRealizarOp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.TextBox txtRetiroTotal;
        private System.Windows.Forms.TextBox txtRetiroCantidad;
        private System.Windows.Forms.TextBox txtDepositoTotal;
        private System.Windows.Forms.TextBox txtDepositoCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

