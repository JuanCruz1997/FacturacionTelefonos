namespace Interfaz
{
    partial class frmFactura
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.gbLocales = new System.Windows.Forms.GroupBox();
            this.txtHoraNoPico = new System.Windows.Forms.TextBox();
            this.lblHoraNoPico = new System.Windows.Forms.Label();
            this.txtHoraPico = new System.Windows.Forms.TextBox();
            this.lblHoraPico = new System.Windows.Forms.Label();
            this.gbNacionales = new System.Windows.Forms.GroupBox();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.txtLitoral = new System.Windows.Forms.TextBox();
            this.txtNOA = new System.Windows.Forms.TextBox();
            this.txtCuyo = new System.Windows.Forms.TextBox();
            this.txtPatagonia = new System.Windows.Forms.TextBox();
            this.lblPatagonia = new System.Windows.Forms.Label();
            this.lblCuyo = new System.Windows.Forms.Label();
            this.lblNOA = new System.Windows.Forms.Label();
            this.lblLitoral = new System.Windows.Forms.Label();
            this.lblCentro = new System.Windows.Forms.Label();
            this.gbInternacionales = new System.Windows.Forms.GroupBox();
            this.txtNorteamerica = new System.Windows.Forms.TextBox();
            this.txtOceania = new System.Windows.Forms.TextBox();
            this.txtAsia = new System.Windows.Forms.TextBox();
            this.txtAfrica = new System.Windows.Forms.TextBox();
            this.txtEuropa = new System.Windows.Forms.TextBox();
            this.txtLATAM = new System.Windows.Forms.TextBox();
            this.lblOceania = new System.Windows.Forms.Label();
            this.lblAsia = new System.Windows.Forms.Label();
            this.lblAfrica = new System.Windows.Forms.Label();
            this.lblEuropa = new System.Windows.Forms.Label();
            this.lblNorteamerica = new System.Windows.Forms.Label();
            this.lblLATAM = new System.Windows.Forms.Label();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.txtFactura = new System.Windows.Forms.RichTextBox();
            this.lblFinde = new System.Windows.Forms.Label();
            this.txtFinde = new System.Windows.Forms.TextBox();
            this.gbLocales.SuspendLayout();
            this.gbNacionales.SuspendLayout();
            this.gbInternacionales.SuspendLayout();
            this.gbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(261, 9);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(320, 20);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bienvenido al sistema de facturación";
            // 
            // gbLocales
            // 
            this.gbLocales.Controls.Add(this.txtFinde);
            this.gbLocales.Controls.Add(this.lblFinde);
            this.gbLocales.Controls.Add(this.txtHoraNoPico);
            this.gbLocales.Controls.Add(this.lblHoraNoPico);
            this.gbLocales.Controls.Add(this.txtHoraPico);
            this.gbLocales.Controls.Add(this.lblHoraPico);
            this.gbLocales.Location = new System.Drawing.Point(13, 34);
            this.gbLocales.Name = "gbLocales";
            this.gbLocales.Size = new System.Drawing.Size(385, 164);
            this.gbLocales.TabIndex = 1;
            this.gbLocales.TabStop = false;
            this.gbLocales.Text = "Llamadas locales";
            // 
            // txtHoraNoPico
            // 
            this.txtHoraNoPico.Location = new System.Drawing.Point(195, 78);
            this.txtHoraNoPico.Name = "txtHoraNoPico";
            this.txtHoraNoPico.Size = new System.Drawing.Size(184, 22);
            this.txtHoraNoPico.TabIndex = 3;
            this.txtHoraNoPico.Text = "0";
            // 
            // lblHoraNoPico
            // 
            this.lblHoraNoPico.AutoSize = true;
            this.lblHoraNoPico.Location = new System.Drawing.Point(6, 78);
            this.lblHoraNoPico.Name = "lblHoraNoPico";
            this.lblHoraNoPico.Size = new System.Drawing.Size(167, 17);
            this.lblHoraNoPico.TabIndex = 2;
            this.lblHoraNoPico.Text = "Minutos en horas no pico";
            // 
            // txtHoraPico
            // 
            this.txtHoraPico.Location = new System.Drawing.Point(195, 33);
            this.txtHoraPico.Name = "txtHoraPico";
            this.txtHoraPico.Size = new System.Drawing.Size(184, 22);
            this.txtHoraPico.TabIndex = 1;
            this.txtHoraPico.Text = "0";
            // 
            // lblHoraPico
            // 
            this.lblHoraPico.AutoSize = true;
            this.lblHoraPico.Location = new System.Drawing.Point(7, 33);
            this.lblHoraPico.Name = "lblHoraPico";
            this.lblHoraPico.Size = new System.Drawing.Size(147, 17);
            this.lblHoraPico.TabIndex = 0;
            this.lblHoraPico.Text = "Minutos en horas pico";
            // 
            // gbNacionales
            // 
            this.gbNacionales.Controls.Add(this.txtCentro);
            this.gbNacionales.Controls.Add(this.txtLitoral);
            this.gbNacionales.Controls.Add(this.txtNOA);
            this.gbNacionales.Controls.Add(this.txtCuyo);
            this.gbNacionales.Controls.Add(this.txtPatagonia);
            this.gbNacionales.Controls.Add(this.lblPatagonia);
            this.gbNacionales.Controls.Add(this.lblCuyo);
            this.gbNacionales.Controls.Add(this.lblNOA);
            this.gbNacionales.Controls.Add(this.lblLitoral);
            this.gbNacionales.Controls.Add(this.lblCentro);
            this.gbNacionales.Location = new System.Drawing.Point(13, 204);
            this.gbNacionales.Name = "gbNacionales";
            this.gbNacionales.Size = new System.Drawing.Size(385, 236);
            this.gbNacionales.TabIndex = 2;
            this.gbNacionales.TabStop = false;
            this.gbNacionales.Text = "Llamadas nacionales";
            // 
            // txtCentro
            // 
            this.txtCentro.Location = new System.Drawing.Point(195, 40);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.Size = new System.Drawing.Size(178, 22);
            this.txtCentro.TabIndex = 9;
            this.txtCentro.Text = "0";
            // 
            // txtLitoral
            // 
            this.txtLitoral.Location = new System.Drawing.Point(195, 79);
            this.txtLitoral.Name = "txtLitoral";
            this.txtLitoral.Size = new System.Drawing.Size(178, 22);
            this.txtLitoral.TabIndex = 8;
            this.txtLitoral.Text = "0";
            // 
            // txtNOA
            // 
            this.txtNOA.Location = new System.Drawing.Point(195, 119);
            this.txtNOA.Name = "txtNOA";
            this.txtNOA.Size = new System.Drawing.Size(178, 22);
            this.txtNOA.TabIndex = 7;
            this.txtNOA.Text = "0";
            // 
            // txtCuyo
            // 
            this.txtCuyo.Location = new System.Drawing.Point(195, 161);
            this.txtCuyo.Name = "txtCuyo";
            this.txtCuyo.Size = new System.Drawing.Size(178, 22);
            this.txtCuyo.TabIndex = 6;
            this.txtCuyo.Text = "0";
            // 
            // txtPatagonia
            // 
            this.txtPatagonia.Location = new System.Drawing.Point(195, 199);
            this.txtPatagonia.Name = "txtPatagonia";
            this.txtPatagonia.Size = new System.Drawing.Size(178, 22);
            this.txtPatagonia.TabIndex = 5;
            this.txtPatagonia.Text = "0";
            // 
            // lblPatagonia
            // 
            this.lblPatagonia.AutoSize = true;
            this.lblPatagonia.Location = new System.Drawing.Point(7, 202);
            this.lblPatagonia.Name = "lblPatagonia";
            this.lblPatagonia.Size = new System.Drawing.Size(181, 17);
            this.lblPatagonia.TabIndex = 4;
            this.lblPatagonia.Text = "Minutos a región Patagonia";
            // 
            // lblCuyo
            // 
            this.lblCuyo.AutoSize = true;
            this.lblCuyo.Location = new System.Drawing.Point(7, 164);
            this.lblCuyo.Name = "lblCuyo";
            this.lblCuyo.Size = new System.Drawing.Size(149, 17);
            this.lblCuyo.TabIndex = 3;
            this.lblCuyo.Text = "Minutos a región Cuyo";
            // 
            // lblNOA
            // 
            this.lblNOA.AutoSize = true;
            this.lblNOA.Location = new System.Drawing.Point(7, 122);
            this.lblNOA.Name = "lblNOA";
            this.lblNOA.Size = new System.Drawing.Size(175, 17);
            this.lblNOA.TabIndex = 2;
            this.lblNOA.Text = "Minutos a región Noroeste";
            // 
            // lblLitoral
            // 
            this.lblLitoral.AutoSize = true;
            this.lblLitoral.Location = new System.Drawing.Point(6, 82);
            this.lblLitoral.Name = "lblLitoral";
            this.lblLitoral.Size = new System.Drawing.Size(156, 17);
            this.lblLitoral.TabIndex = 1;
            this.lblLitoral.Text = "Minutos a región Litoral";
            // 
            // lblCentro
            // 
            this.lblCentro.AutoSize = true;
            this.lblCentro.Location = new System.Drawing.Point(7, 43);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(159, 17);
            this.lblCentro.TabIndex = 0;
            this.lblCentro.Text = "Minutos a región Centro";
            // 
            // gbInternacionales
            // 
            this.gbInternacionales.Controls.Add(this.txtNorteamerica);
            this.gbInternacionales.Controls.Add(this.txtOceania);
            this.gbInternacionales.Controls.Add(this.txtAsia);
            this.gbInternacionales.Controls.Add(this.txtAfrica);
            this.gbInternacionales.Controls.Add(this.txtEuropa);
            this.gbInternacionales.Controls.Add(this.txtLATAM);
            this.gbInternacionales.Controls.Add(this.lblOceania);
            this.gbInternacionales.Controls.Add(this.lblAsia);
            this.gbInternacionales.Controls.Add(this.lblAfrica);
            this.gbInternacionales.Controls.Add(this.lblEuropa);
            this.gbInternacionales.Controls.Add(this.lblNorteamerica);
            this.gbInternacionales.Controls.Add(this.lblLATAM);
            this.gbInternacionales.Location = new System.Drawing.Point(414, 34);
            this.gbInternacionales.Name = "gbInternacionales";
            this.gbInternacionales.Size = new System.Drawing.Size(352, 225);
            this.gbInternacionales.TabIndex = 3;
            this.gbInternacionales.TabStop = false;
            this.gbInternacionales.Text = "Llamadas internacionales";
            // 
            // txtNorteamerica
            // 
            this.txtNorteamerica.Location = new System.Drawing.Point(174, 64);
            this.txtNorteamerica.Name = "txtNorteamerica";
            this.txtNorteamerica.Size = new System.Drawing.Size(166, 22);
            this.txtNorteamerica.TabIndex = 11;
            this.txtNorteamerica.Text = "0";
            // 
            // txtOceania
            // 
            this.txtOceania.Location = new System.Drawing.Point(174, 182);
            this.txtOceania.Name = "txtOceania";
            this.txtOceania.Size = new System.Drawing.Size(166, 22);
            this.txtOceania.TabIndex = 10;
            this.txtOceania.Text = "0";
            // 
            // txtAsia
            // 
            this.txtAsia.Location = new System.Drawing.Point(174, 152);
            this.txtAsia.Name = "txtAsia";
            this.txtAsia.Size = new System.Drawing.Size(166, 22);
            this.txtAsia.TabIndex = 9;
            this.txtAsia.Text = "0";
            // 
            // txtAfrica
            // 
            this.txtAfrica.Location = new System.Drawing.Point(174, 124);
            this.txtAfrica.Name = "txtAfrica";
            this.txtAfrica.Size = new System.Drawing.Size(166, 22);
            this.txtAfrica.TabIndex = 8;
            this.txtAfrica.Text = "0";
            // 
            // txtEuropa
            // 
            this.txtEuropa.Location = new System.Drawing.Point(174, 95);
            this.txtEuropa.Name = "txtEuropa";
            this.txtEuropa.Size = new System.Drawing.Size(166, 22);
            this.txtEuropa.TabIndex = 7;
            this.txtEuropa.Text = "0";
            // 
            // txtLATAM
            // 
            this.txtLATAM.Location = new System.Drawing.Point(174, 32);
            this.txtLATAM.Name = "txtLATAM";
            this.txtLATAM.Size = new System.Drawing.Size(166, 22);
            this.txtLATAM.TabIndex = 6;
            this.txtLATAM.Text = "0";
            // 
            // lblOceania
            // 
            this.lblOceania.AutoSize = true;
            this.lblOceania.Location = new System.Drawing.Point(6, 185);
            this.lblOceania.Name = "lblOceania";
            this.lblOceania.Size = new System.Drawing.Size(126, 17);
            this.lblOceania.TabIndex = 5;
            this.lblOceania.Text = "Minutos a Oceanía";
            // 
            // lblAsia
            // 
            this.lblAsia.AutoSize = true;
            this.lblAsia.Location = new System.Drawing.Point(6, 155);
            this.lblAsia.Name = "lblAsia";
            this.lblAsia.Size = new System.Drawing.Size(100, 17);
            this.lblAsia.TabIndex = 4;
            this.lblAsia.Text = "Minutos a Asia";
            // 
            // lblAfrica
            // 
            this.lblAfrica.AutoSize = true;
            this.lblAfrica.Location = new System.Drawing.Point(6, 127);
            this.lblAfrica.Name = "lblAfrica";
            this.lblAfrica.Size = new System.Drawing.Size(109, 17);
            this.lblAfrica.TabIndex = 3;
            this.lblAfrica.Text = "Minutos a África";
            // 
            // lblEuropa
            // 
            this.lblEuropa.AutoSize = true;
            this.lblEuropa.Location = new System.Drawing.Point(5, 98);
            this.lblEuropa.Name = "lblEuropa";
            this.lblEuropa.Size = new System.Drawing.Size(119, 17);
            this.lblEuropa.TabIndex = 2;
            this.lblEuropa.Text = "Minutos a Europa";
            // 
            // lblNorteamerica
            // 
            this.lblNorteamerica.AutoSize = true;
            this.lblNorteamerica.Location = new System.Drawing.Point(5, 67);
            this.lblNorteamerica.Name = "lblNorteamerica";
            this.lblNorteamerica.Size = new System.Drawing.Size(158, 17);
            this.lblNorteamerica.TabIndex = 1;
            this.lblNorteamerica.Text = "Minutos a Norteamérica";
            // 
            // lblLATAM
            // 
            this.lblLATAM.AutoSize = true;
            this.lblLATAM.Location = new System.Drawing.Point(5, 32);
            this.lblLATAM.Name = "lblLATAM";
            this.lblLATAM.Size = new System.Drawing.Size(162, 17);
            this.lblLATAM.TabIndex = 0;
            this.lblLATAM.Text = "Minutos a Latinoámerica";
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(414, 328);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(352, 34);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(414, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(352, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(414, 368);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(352, 34);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.txtFactura);
            this.gbFactura.Location = new System.Drawing.Point(772, 13);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(360, 427);
            this.gbFactura.TabIndex = 7;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Factura";
            this.gbFactura.Visible = false;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(7, 22);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(347, 399);
            this.txtFactura.TabIndex = 0;
            this.txtFactura.Text = "";
            // 
            // lblFinde
            // 
            this.lblFinde.AutoSize = true;
            this.lblFinde.Location = new System.Drawing.Point(7, 124);
            this.lblFinde.Name = "lblFinde";
            this.lblFinde.Size = new System.Drawing.Size(165, 17);
            this.lblFinde.TabIndex = 4;
            this.lblFinde.Text = "Minutos fines de semana";
            // 
            // txtFinde
            // 
            this.txtFinde.Location = new System.Drawing.Point(195, 123);
            this.txtFinde.Name = "txtFinde";
            this.txtFinde.Size = new System.Drawing.Size(184, 22);
            this.txtFinde.TabIndex = 5;
            this.txtFinde.Text = "0";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 452);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.gbInternacionales);
            this.Controls.Add(this.gbNacionales);
            this.Controls.Add(this.gbLocales);
            this.Controls.Add(this.lblInicio);
            this.Name = "frmFactura";
            this.Text = "Nueva factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.gbLocales.ResumeLayout(false);
            this.gbLocales.PerformLayout();
            this.gbNacionales.ResumeLayout(false);
            this.gbNacionales.PerformLayout();
            this.gbInternacionales.ResumeLayout(false);
            this.gbInternacionales.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.GroupBox gbLocales;
        private System.Windows.Forms.TextBox txtHoraNoPico;
        private System.Windows.Forms.Label lblHoraNoPico;
        private System.Windows.Forms.TextBox txtHoraPico;
        private System.Windows.Forms.Label lblHoraPico;
        private System.Windows.Forms.GroupBox gbNacionales;
        private System.Windows.Forms.Label lblPatagonia;
        private System.Windows.Forms.Label lblCuyo;
        private System.Windows.Forms.Label lblNOA;
        private System.Windows.Forms.Label lblLitoral;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.TextBox txtLitoral;
        private System.Windows.Forms.TextBox txtNOA;
        private System.Windows.Forms.TextBox txtCuyo;
        private System.Windows.Forms.TextBox txtPatagonia;
        private System.Windows.Forms.GroupBox gbInternacionales;
        private System.Windows.Forms.Label lblLATAM;
        private System.Windows.Forms.TextBox txtNorteamerica;
        private System.Windows.Forms.TextBox txtOceania;
        private System.Windows.Forms.TextBox txtAsia;
        private System.Windows.Forms.TextBox txtAfrica;
        private System.Windows.Forms.TextBox txtEuropa;
        private System.Windows.Forms.TextBox txtLATAM;
        private System.Windows.Forms.Label lblOceania;
        private System.Windows.Forms.Label lblAsia;
        private System.Windows.Forms.Label lblAfrica;
        private System.Windows.Forms.Label lblEuropa;
        private System.Windows.Forms.Label lblNorteamerica;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.RichTextBox txtFactura;
        private System.Windows.Forms.TextBox txtFinde;
        private System.Windows.Forms.Label lblFinde;
    }
}

