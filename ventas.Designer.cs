namespace pryGrafeuilleTP1parte2
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbFacturaTipo = new System.Windows.Forms.ComboBox();
            this.cbIDvendedor = new System.Windows.Forms.ComboBox();
            this.cbClienteID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Enabled = false;
            this.btnGuardarDatos.Location = new System.Drawing.Point(15, 194);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(97, 32);
            this.btnGuardarDatos.TabIndex = 28;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Numero De Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Factura Tipo";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(134, 92);
            this.txtNumeroFactura.MaxLength = 5;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(191, 20);
            this.txtNumeroFactura.TabIndex = 25;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(131, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(194, 20);
            this.dtpFecha.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cliente ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID vendedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(131, 155);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(194, 20);
            this.txtMonto.TabIndex = 38;
            // 
            // cbFacturaTipo
            // 
            this.cbFacturaTipo.FormattingEnabled = true;
            this.cbFacturaTipo.Location = new System.Drawing.Point(15, 37);
            this.cbFacturaTipo.Name = "cbFacturaTipo";
            this.cbFacturaTipo.Size = new System.Drawing.Size(97, 21);
            this.cbFacturaTipo.TabIndex = 39;
            // 
            // cbIDvendedor
            // 
            this.cbIDvendedor.FormattingEnabled = true;
            this.cbIDvendedor.Location = new System.Drawing.Point(15, 155);
            this.cbIDvendedor.Name = "cbIDvendedor";
            this.cbIDvendedor.Size = new System.Drawing.Size(97, 21);
            this.cbIDvendedor.TabIndex = 40;
            // 
            // cbClienteID
            // 
            this.cbClienteID.FormattingEnabled = true;
            this.cbClienteID.Location = new System.Drawing.Point(15, 91);
            this.cbClienteID.Name = "cbClienteID";
            this.cbClienteID.Size = new System.Drawing.Size(97, 21);
            this.cbClienteID.TabIndex = 41;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 238);
            this.Controls.Add(this.cbClienteID);
            this.Controls.Add(this.cbIDvendedor);
            this.Controls.Add(this.cbFacturaTipo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cbFacturaTipo;
        private System.Windows.Forms.ComboBox cbIDvendedor;
        private System.Windows.Forms.ComboBox cbClienteID;
    }
}