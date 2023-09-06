using AppBanco1_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
//using AppBanco1_3.Datos;

namespace AppBanco1_3.vista
{
    public partial class CuentaF : Form
    {
        
        public CuentaF()
        {
            InitializeComponent();
           
        }
        Datos BD = new Datos();

        private bool Validar()
        {
            bool x = false;
            
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre");
                    return false;
                }
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Ingrese un Apellido");
                    return false;
                }
                string DNI = TxtDNI.Text;
                if (!(!string.IsNullOrWhiteSpace(DNI) && EsNumero(DNI)))
                {
                    MessageBox.Show("Ingrese un DNI Valido");
                    return false;
                }
                x = true;
            


            return x;
        }
        //private void cargarNro()
        //{
        //    //SqlConnection cnn = new SqlConnection();
        //    //cnn.ConnectionString = @"Data Source=localhost;Initial Catalog=BANCO2;Integrated Security=True";
        //    //cnn.Open();
        //    //SqlCommand cmd = new
        //    //SqlCommand("PROXIMO_ID", cnn);
        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    //SqlParameter param = new SqlParameter("@Proximo_id",
        //    //SqlDbType.Int);
        //    //param.Direction = ParameterDirection.Output;
        //    //cmd.Parameters.Add(param);
        //    //cmd.ExecuteNonQuery();
        //    //int next = Convert.ToInt32(param.Value);
        //    //lblNroCuenta.Text = "Presupuesto Nº: " +
        //    //next.ToString();
        //    //cnn.Close();
        //}
        private bool EsNumero(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }

        private void lblNroCuenta_Click(object sender, EventArgs e)
        {

        }

        private void CuentaF_Load(object sender, EventArgs e)
        {
            //string cadenaConnecion = "Data Source=localhost;Initial Catalog=BANCO2;Integrated Security=True";
            //SqlConnection coneccion = new SqlConnection(cadenaConnecion);
            //SqlCommand comando = new SqlCommand();
            //comando.Connection = coneccion;
            //comando.CommandType = CommandType.StoredProcedure;
            DataTable t = BD.SP_COMBO("TipoCuenta");
            cboCantidad.SelectedIndex = 0;
            cboTipoCuenta.DataSource = t;
            cboTipoCuenta.ValueMember = t.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = t.Columns[0].ColumnName;
            lblNroCuenta.Text += " " +Convert.ToString( BD.SP_ID());

    }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

            
            //amen y buenas noches
            if (Validar())
            {
                Cliente Client = new Cliente();
                Client.Nombre = txtNombre.Text;
                Client.Apellido = txtApellido.Text;
                Client.DNI = Convert.ToInt32(TxtDNI.Text);
                for (int i = 0; i < Convert.ToInt32(cboCantidad.SelectedIndex + 1); i++)
                {
                    Cuenta Cuentita = new Cuenta();
                    TipoCuenta tp = new TipoCuenta(Convert.ToString(cboTipoCuenta.SelectedValue),Convert.ToInt32(cboTipoCuenta.SelectedIndex + 1));
                    Cuentita.saldo = Convert.ToDouble(txtDinero.Text);
                    Cuentita.tipo = tp;
                    Client.lista.Add(Cuentita);
                }

                 if (BD.SP_INSERTAR(Client)) { 
                MessageBox.Show("Felicidades su cuenta se creo correctamente");
                 }
        }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
