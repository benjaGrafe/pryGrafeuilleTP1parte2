namespace pryGrafeuilleTP1parte2
{
    partial class frmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedor));
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkComisión = new System.Windows.Forms.CheckBox();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDvendedor = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(12, 136);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 23;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkComisión
            // 
            this.chkComisión.AutoSize = true;
            this.chkComisión.Location = new System.Drawing.Point(12, 113);
            this.chkComisión.Name = "chkComisión";
            this.chkComisión.Size = new System.Drawing.Size(68, 17);
            this.chkComisión.TabIndex = 22;
            this.chkComisión.Text = "Comisión";
            this.chkComisión.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Enabled = false;
            this.btnGuardarDatos.Location = new System.Drawing.Point(12, 174);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(100, 32);
            this.btnGuardarDatos.TabIndex = 21;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID vendedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // txtIDvendedor
            // 
            this.txtIDvendedor.Location = new System.Drawing.Point(12, 74);
            this.txtIDvendedor.Name = "txtIDvendedor";
            this.txtIDvendedor.Size = new System.Drawing.Size(197, 20);
            this.txtIDvendedor.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 221);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.chkComisión);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDvendedor);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendedor";
            this.Text = "Registro De Vendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkComisión;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDvendedor;
        private System.Windows.Forms.TextBox txtNombre;
    }
}