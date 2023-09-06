namespace AppBanco1_3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCbuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCbuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltoTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltoTiempoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.transferirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inciarSesionToolStripMenuItem,
            this.crearToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            this.cuentaToolStripMenuItem.Click += new System.EventHandler(this.cuentaToolStripMenuItem_Click);
            // 
            // inciarSesionToolStripMenuItem
            // 
            this.inciarSesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCbuToolStripMenuItem});
            this.inciarSesionToolStripMenuItem.Name = "inciarSesionToolStripMenuItem";
            this.inciarSesionToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.inciarSesionToolStripMenuItem.Text = "Consultar";
            this.inciarSesionToolStripMenuItem.Click += new System.EventHandler(this.inciarSesionToolStripMenuItem_Click);
            // 
            // consultarCbuToolStripMenuItem
            // 
            this.consultarCbuToolStripMenuItem.Name = "consultarCbuToolStripMenuItem";
            this.consultarCbuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.consultarCbuToolStripMenuItem.Text = "Consultar Cbu";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click_1);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarCuentaToolStripMenuItem,
            this.modificarCuentaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // eliminarCuentaToolStripMenuItem
            // 
            this.eliminarCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltoTiempoToolStripMenuItem});
            this.eliminarCuentaToolStripMenuItem.Name = "eliminarCuentaToolStripMenuItem";
            this.eliminarCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarCuentaToolStripMenuItem.Text = "Eliminar Cuenta";
            // 
            // modificarCuentaToolStripMenuItem
            // 
            this.modificarCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltoTiempoToolStripMenuItem1});
            this.modificarCuentaToolStripMenuItem.Name = "modificarCuentaToolStripMenuItem";
            this.modificarCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarCuentaToolStripMenuItem.Text = "Modificar Cuenta";
            // 
            // transferirToolStripMenuItem
            // 
            this.transferirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCbuToolStripMenuItem});
            this.transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            this.transferirToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transferirToolStripMenuItem.Text = "Transferir";
            // 
            // porCbuToolStripMenuItem
            // 
            this.porCbuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enProcesoToolStripMenuItem});
            this.porCbuToolStripMenuItem.Name = "porCbuToolStripMenuItem";
            this.porCbuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCbuToolStripMenuItem.Text = "Por Cbu";
            // 
            // enProcesoToolStripMenuItem
            // 
            this.enProcesoToolStripMenuItem.Name = "enProcesoToolStripMenuItem";
            this.enProcesoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enProcesoToolStripMenuItem.Text = "Falto Tiempo";
            this.enProcesoToolStripMenuItem.Click += new System.EventHandler(this.enProcesoToolStripMenuItem_Click);
            // 
            // faltoTiempoToolStripMenuItem
            // 
            this.faltoTiempoToolStripMenuItem.Name = "faltoTiempoToolStripMenuItem";
            this.faltoTiempoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faltoTiempoToolStripMenuItem.Text = "Falto Tiempo";
            // 
            // faltoTiempoToolStripMenuItem1
            // 
            this.faltoTiempoToolStripMenuItem1.Name = "faltoTiempoToolStripMenuItem1";
            this.faltoTiempoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.faltoTiempoToolStripMenuItem1.Text = "Falto Tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCbuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCbuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltoTiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltoTiempoToolStripMenuItem1;
    }
}

