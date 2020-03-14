namespace WindowsFormsApp1
{
    partial class ViajesForm
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
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.txtRemito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalDest = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnidadDest = new System.Windows.Forms.TextBox();
            this.txtCantidadDest = new System.Windows.Forms.TextBox();
            this.txtValorDest = new System.Windows.Forms.TextBox();
            this.txtDetalleDest = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadDestinatario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoDest = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCuilDest = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDest = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.txtComprobanteTrans = new System.Windows.Forms.TextBox();
            this.txtDetalleTrans = new System.Windows.Forms.TextBox();
            this.txtImporteTrans = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalTrans = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnidadTrans = new System.Windows.Forms.TextBox();
            this.txtCantidadTrans = new System.Windows.Forms.TextBox();
            this.txtValorTrans = new System.Windows.Forms.TextBox();
            this.txtDetalleTrans2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTipoTrans = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbCuilTrans = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreTrans = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(55, 13);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 20);
            this.date1.TabIndex = 0;
            // 
            // txtRemito
            // 
            this.txtRemito.Location = new System.Drawing.Point(688, 12);
            this.txtRemito.Name = "txtRemito";
            this.txtRemito.Size = new System.Drawing.Size(100, 20);
            this.txtRemito.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "REMITO Nº";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalDest);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUnidadDest);
            this.groupBox1.Controls.Add(this.txtCantidadDest);
            this.groupBox1.Controls.Add(this.txtValorDest);
            this.groupBox1.Controls.Add(this.txtDetalleDest);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCantidadDestinatario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTipoDest);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCuilDest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreDest);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DESTINATARIO";
            // 
            // txtTotalDest
            // 
            this.txtTotalDest.Location = new System.Drawing.Point(510, 111);
            this.txtTotalDest.Name = "txtTotalDest";
            this.txtTotalDest.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDest.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "TOTAL";
            // 
            // txtUnidadDest
            // 
            this.txtUnidadDest.Location = new System.Drawing.Point(6, 72);
            this.txtUnidadDest.Name = "txtUnidadDest";
            this.txtUnidadDest.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadDest.TabIndex = 3;
            // 
            // txtCantidadDest
            // 
            this.txtCantidadDest.Location = new System.Drawing.Point(158, 72);
            this.txtCantidadDest.Name = "txtCantidadDest";
            this.txtCantidadDest.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDest.TabIndex = 4;
            // 
            // txtValorDest
            // 
            this.txtValorDest.Location = new System.Drawing.Point(321, 72);
            this.txtValorDest.Name = "txtValorDest";
            this.txtValorDest.Size = new System.Drawing.Size(157, 20);
            this.txtValorDest.TabIndex = 5;
            // 
            // txtDetalleDest
            // 
            this.txtDetalleDest.Location = new System.Drawing.Point(510, 72);
            this.txtDetalleDest.Name = "txtDetalleDest";
            this.txtDetalleDest.Size = new System.Drawing.Size(260, 20);
            this.txtDetalleDest.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Detalle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Valor";
            // 
            // txtCantidadDestinatario
            // 
            this.txtCantidadDestinatario.AutoSize = true;
            this.txtCantidadDestinatario.Location = new System.Drawing.Point(155, 56);
            this.txtCantidadDestinatario.Name = "txtCantidadDestinatario";
            this.txtCantidadDestinatario.Size = new System.Drawing.Size(49, 13);
            this.txtCantidadDestinatario.TabIndex = 7;
            this.txtCantidadDestinatario.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unidad de Trabajo";
            // 
            // cmbTipoDest
            // 
            this.cmbTipoDest.FormattingEnabled = true;
            this.cmbTipoDest.Location = new System.Drawing.Point(609, 33);
            this.cmbTipoDest.Name = "cmbTipoDest";
            this.cmbTipoDest.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoDest.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre/ Razon Social";
            // 
            // cmbCuilDest
            // 
            this.cmbCuilDest.FormattingEnabled = true;
            this.cmbCuilDest.Location = new System.Drawing.Point(6, 32);
            this.cmbCuilDest.Name = "cmbCuilDest";
            this.cmbCuilDest.Size = new System.Drawing.Size(194, 21);
            this.cmbCuilDest.TabIndex = 0;
            this.cmbCuilDest.SelectedIndexChanged += new System.EventHandler(this.cmbCuilDest_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CUIL/CUIT";
            // 
            // txtNombreDest
            // 
            this.txtNombreDest.Enabled = false;
            this.txtNombreDest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreDest.Location = new System.Drawing.Point(228, 33);
            this.txtNombreDest.Name = "txtNombreDest";
            this.txtNombreDest.Size = new System.Drawing.Size(342, 20);
            this.txtNombreDest.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.date2);
            this.groupBox2.Controls.Add(this.btnMenos);
            this.groupBox2.Controls.Add(this.btnMas);
            this.groupBox2.Controls.Add(this.txtComprobanteTrans);
            this.groupBox2.Controls.Add(this.txtDetalleTrans);
            this.groupBox2.Controls.Add(this.txtImporteTrans);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtTotalTrans);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUnidadTrans);
            this.groupBox2.Controls.Add(this.txtCantidadTrans);
            this.groupBox2.Controls.Add(this.txtValorTrans);
            this.groupBox2.Controls.Add(this.txtDetalleTrans2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbTipoTrans);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmbCuilTrans);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtNombreTrans);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 304);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRANSPORTISTA";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 112);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(6, 72);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 20);
            this.date2.TabIndex = 3;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(727, 98);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(43, 23);
            this.btnMenos.TabIndex = 8;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(727, 69);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(43, 23);
            this.btnMas.TabIndex = 7;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // txtComprobanteTrans
            // 
            this.txtComprobanteTrans.Location = new System.Drawing.Point(228, 72);
            this.txtComprobanteTrans.Name = "txtComprobanteTrans";
            this.txtComprobanteTrans.Size = new System.Drawing.Size(100, 20);
            this.txtComprobanteTrans.TabIndex = 4;
            // 
            // txtDetalleTrans
            // 
            this.txtDetalleTrans.Location = new System.Drawing.Point(334, 72);
            this.txtDetalleTrans.Name = "txtDetalleTrans";
            this.txtDetalleTrans.Size = new System.Drawing.Size(244, 20);
            this.txtDetalleTrans.TabIndex = 5;
            // 
            // txtImporteTrans
            // 
            this.txtImporteTrans.Location = new System.Drawing.Point(584, 72);
            this.txtImporteTrans.Name = "txtImporteTrans";
            this.txtImporteTrans.Size = new System.Drawing.Size(123, 20);
            this.txtImporteTrans.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 56);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Fecha";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(225, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Comprobante Nº";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(334, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Detalle";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(581, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "IMPORTE";
            // 
            // txtTotalTrans
            // 
            this.txtTotalTrans.Location = new System.Drawing.Point(510, 268);
            this.txtTotalTrans.Name = "txtTotalTrans";
            this.txtTotalTrans.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTrans.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "TOTAL";
            // 
            // txtUnidadTrans
            // 
            this.txtUnidadTrans.Location = new System.Drawing.Point(6, 229);
            this.txtUnidadTrans.Name = "txtUnidadTrans";
            this.txtUnidadTrans.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadTrans.TabIndex = 10;
            // 
            // txtCantidadTrans
            // 
            this.txtCantidadTrans.Location = new System.Drawing.Point(158, 229);
            this.txtCantidadTrans.Name = "txtCantidadTrans";
            this.txtCantidadTrans.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadTrans.TabIndex = 11;
            // 
            // txtValorTrans
            // 
            this.txtValorTrans.Location = new System.Drawing.Point(321, 229);
            this.txtValorTrans.Name = "txtValorTrans";
            this.txtValorTrans.Size = new System.Drawing.Size(157, 20);
            this.txtValorTrans.TabIndex = 12;
            // 
            // txtDetalleTrans2
            // 
            this.txtDetalleTrans2.Location = new System.Drawing.Point(510, 229);
            this.txtDetalleTrans2.Name = "txtDetalleTrans2";
            this.txtDetalleTrans2.Size = new System.Drawing.Size(260, 20);
            this.txtDetalleTrans2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(507, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Detalle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Valor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Unidad de Trabajo";
            // 
            // cmbTipoTrans
            // 
            this.cmbTipoTrans.FormattingEnabled = true;
            this.cmbTipoTrans.Location = new System.Drawing.Point(609, 33);
            this.cmbTipoTrans.Name = "cmbTipoTrans";
            this.cmbTipoTrans.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoTrans.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(606, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "TIPO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(225, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Nombre/ Razon Social";
            // 
            // cmbCuilTrans
            // 
            this.cmbCuilTrans.FormattingEnabled = true;
            this.cmbCuilTrans.Location = new System.Drawing.Point(6, 32);
            this.cmbCuilTrans.Name = "cmbCuilTrans";
            this.cmbCuilTrans.Size = new System.Drawing.Size(194, 21);
            this.cmbCuilTrans.TabIndex = 0;
            this.cmbCuilTrans.SelectedIndexChanged += new System.EventHandler(this.cmbCuilTrans_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "CUIL/CUIT";
            // 
            // txtNombreTrans
            // 
            this.txtNombreTrans.Enabled = false;
            this.txtNombreTrans.Location = new System.Drawing.Point(228, 33);
            this.txtNombreTrans.Name = "txtNombreTrans";
            this.txtNombreTrans.Size = new System.Drawing.Size(342, 20);
            this.txtNombreTrans.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(707, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(596, 510);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemito);
            this.Controls.Add(this.date1);
            this.Name = "ViajesForm";
            this.Text = "ViajesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.TextBox txtRemito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalDest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnidadDest;
        private System.Windows.Forms.TextBox txtCantidadDest;
        private System.Windows.Forms.TextBox txtValorDest;
        private System.Windows.Forms.TextBox txtDetalleDest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtCantidadDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCuilDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalTrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnidadTrans;
        private System.Windows.Forms.TextBox txtCantidadTrans;
        private System.Windows.Forms.TextBox txtValorTrans;
        private System.Windows.Forms.TextBox txtDetalleTrans2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbTipoTrans;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbCuilTrans;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreTrans;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.TextBox txtComprobanteTrans;
        private System.Windows.Forms.TextBox txtDetalleTrans;
        private System.Windows.Forms.TextBox txtImporteTrans;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListView listView1;
    }
}