using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco1_3.vista
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }
         Datos BDhelper = new Datos();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           dataGridView1.Rows.Clear();
           Cliente cliente = new Cliente(); 
            cliente.Apellido = Convert.ToString(txtApellido.Text);
            cliente.Nombre = Convert.ToString(txtNombre.Text);
            if (txtDNI.Text == string.Empty) {
                cliente.DNI = 40000000;
            }
            else
            {
                cliente.DNI = Convert.ToInt32(txtDNI.Text);
            }
            foreach (DataRow row in dataGridView1.Rows)
            {

            }
             DataTable t = BDhelper.SP_CONSULTAR_CLIENTE(cliente);
            foreach (DataRow row in t.Rows)
            {
                // Agrega una nueva fila al DataGridView.
                int rowIndex = dataGridView1.Rows.Add();

                // Llena las celdas de la fila con los valores de la tabla de datos.
                dataGridView1.Rows[rowIndex].Cells["Col_id_cliente"].Value = row["id_cliente"];
                dataGridView1.Rows[rowIndex].Cells["ColNombre"].Value = row["nombre"];
                dataGridView1.Rows[rowIndex].Cells["ColApellido"].Value = row["apellido"];
                dataGridView1.Rows[rowIndex].Cells["ColDni"].Value = row["dni"];
                // Agrega más columnas según sea necesario.
             
            }
        }
    }
}
