namespace AppBanco1_3.vista
{
    partial class CuentaF
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNroCuenta = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.cboCantidad = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(278, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(278, 131);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(338, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(338, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(123, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(338, 176);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(123, 20);
            this.TxtDNI.TabIndex = 4;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(296, 176);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCuenta.Location = new System.Drawing.Point(200, 43);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(121, 24);
            this.lblNroCuenta.TabIndex = 6;
            this.lblNroCuenta.Text = "Cliente Nro:";
            this.lblNroCuenta.Click += new System.EventHandler(this.lblNroCuenta_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.BtnCrear.Location = new System.Drawing.Point(338, 328);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(100, 23);
            this.BtnCrear.TabIndex = 7;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(242, 220);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(80, 13);
            this.lblTipoCuenta.TabIndex = 8;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(338, 217);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(123, 21);
            this.cboTipoCuenta.TabIndex = 9;
            this.cboTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboCantidad
            // 
            this.cboCantidad.FormattingEnabled = true;
            this.cboCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboCantidad.Location = new System.Drawing.Point(502, 168);
            this.cboCantidad.Name = "cboCantidad";
            this.cboCantidad.Size = new System.Drawing.Size(123, 21);
            this.cboCantidad.TabIndex = 11;
            this.cboCantidad.SelectedIndexChanged += new System.EventHandler(this.cboCantidad_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(499, 131);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad de Cuentas:";
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(502, 85);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(123, 20);
            this.txtDinero.TabIndex = 13;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(499, 54);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(41, 13);
            this.lblDinero.TabIndex = 14;
            this.lblDinero.Text = "Dinero:";
            // 
            // CuentaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.txtDinero);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboCantidad);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.lblNroCuenta);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "CuentaF";
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.CuentaF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNroCuenta;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.ComboBox cboCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.Label lblDinero;
    }
}