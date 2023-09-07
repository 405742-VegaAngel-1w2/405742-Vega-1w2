using AppBanco1_3;
using AppBanco1_3.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco1_3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void inciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Mostrar el formulario de destino
           
        }

        private void crearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CuentaF formInciarSesion = new CuentaF();

            formInciarSesion.ShowDialog();
        }

        private void enProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarCbuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultar  Consultar = new FrmConsultar();
            Consultar.ShowDialog();
        }
    }
}
