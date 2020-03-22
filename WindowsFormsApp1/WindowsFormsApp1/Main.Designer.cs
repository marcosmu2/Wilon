namespace WindowsFormsApp1
{
    partial class Main
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
            this.btnTerceros = new System.Windows.Forms.Button();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnCuentasCorrientes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCobros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTerceros
            // 
            this.btnTerceros.Location = new System.Drawing.Point(12, 12);
            this.btnTerceros.Name = "btnTerceros";
            this.btnTerceros.Size = new System.Drawing.Size(148, 36);
            this.btnTerceros.TabIndex = 0;
            this.btnTerceros.Text = "Agregar Terceros";
            this.btnTerceros.UseVisualStyleBackColor = true;
            this.btnTerceros.Click += new System.EventHandler(this.btnTerceros_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(12, 54);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(148, 36);
            this.btnViajes.TabIndex = 1;
            this.btnViajes.Text = "Registro de Viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Location = new System.Drawing.Point(12, 96);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(148, 36);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnCuentasCorrientes
            // 
            this.btnCuentasCorrientes.Location = new System.Drawing.Point(12, 138);
            this.btnCuentasCorrientes.Name = "btnCuentasCorrientes";
            this.btnCuentasCorrientes.Size = new System.Drawing.Size(148, 36);
            this.btnCuentasCorrientes.TabIndex = 3;
            this.btnCuentasCorrientes.Text = "Cuentas Corrientes";
            this.btnCuentasCorrientes.UseVisualStyleBackColor = true;
            this.btnCuentasCorrientes.Click += new System.EventHandler(this.btnCuentasCorrientes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(12, 180);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(148, 36);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCobros
            // 
            this.btnCobros.Location = new System.Drawing.Point(12, 222);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(148, 36);
            this.btnCobros.TabIndex = 5;
            this.btnCobros.Text = "Cobros";
            this.btnCobros.UseVisualStyleBackColor = true;
            this.btnCobros.Click += new System.EventHandler(this.btnCobros_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCobros);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnCuentasCorrientes);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnViajes);
            this.Controls.Add(this.btnTerceros);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerceros;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnCuentasCorrientes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCobros;
    }
}