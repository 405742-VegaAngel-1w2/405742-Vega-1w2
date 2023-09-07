using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using AppBanco1_3;
using System.Windows.Forms;

namespace AppBanco1_3
{
    public class Datos
    {
        private string cadenaConnecion = "Data Source=localhost;Initial Catalog=BANCO2;Integrated Security=True";
        private SqlConnection coneccion;
        private SqlCommand comando;
      
     

        public Datos()
        {

            coneccion = new SqlConnection(cadenaConnecion);
            comando = new SqlCommand();
           
        }
        public void AbrirConexion()
        {
            comando.Connection = coneccion;

            coneccion.Open();
            
         
        }
        public DataTable SP_COMBO(string tabla)
        {
            AbrirConexion();
            comando = new SqlCommand("CARGAR_COMBO", coneccion);
            comando.CommandType = CommandType.StoredProcedure;
            

            SqlParameter param = new SqlParameter("@tabla", SqlDbType.VarChar);
           // param.Direction = ParameterDirection.Input;
            
            param.Value = tabla;
            comando.Parameters.Add(param) ;

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            CerrarConexion();
            return dt;
        }
        public DataTable SP_CONSULTAR_CLIENTE(Cliente client)
        {
            AbrirConexion();
            comando = new SqlCommand("SP_CONSULTAR_CLIENTES", coneccion);
            DataTable dt = new DataTable();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", client.Nombre);
            comando.Parameters.AddWithValue("@apellido", client.Apellido);
            comando.Parameters.AddWithValue("@dni", client.DNI);
            dt.Load(comando.ExecuteReader());
            CerrarConexion() ;
            return dt;
        }

        public bool SP_INSERTAR(Cliente client)
        {
            bool resultado = true;
            SqlTransaction T = null;

            try { 
                      //insertar el cliente
                    AbrirConexion();
                    T = coneccion.BeginTransaction();
                    comando = new SqlCommand("SP_INSERTAR_CLIENTE", coneccion,T);

                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", client.Nombre);
                    comando.Parameters.AddWithValue("@apellido", client.Apellido);
                    comando.Parameters.AddWithValue("@dni", client.DNI);
                    SqlParameter Paramer = new SqlParameter("@id", SqlDbType.Int);
                    Paramer.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(Paramer);
                    comando.ExecuteNonQuery();
                    int id_devuelto = Convert.ToInt32(Paramer.Value);
                    MessageBox.Show("el cliente anduvo bien");

            //insertar la cuenta
            //inserta varias cuentas a nombre de un cliente 
            MessageBox.Show($"el id devuelto es{id_devuelto}");
            
            foreach (var i in client.lista)
                {
                    SqlCommand comando2 = new SqlCommand("SP_INSERTAR_CUENTA", coneccion, T);
                    comando2.CommandType =CommandType.StoredProcedure;
                    comando2.Parameters.AddWithValue("@cbu", i.cbu);
                    comando2.Parameters.AddWithValue("@saldo",i.saldo);
                    comando2.Parameters.AddWithValue("@id_tipo_cuenta",i.tipo.id);
                    comando2.Parameters.AddWithValue("@id_cliente",id_devuelto);
                    comando2.ExecuteNonQuery();
      
                }
             
                     T.Commit();
                CerrarConexion();
            }
            catch {
                T.Rollback();
                resultado = false;
                MessageBox.Show("La transaccion fue rechazada");
            }
            finally
            {
                if (coneccion != null && coneccion.State == ConnectionState.Open)
                    coneccion.Close();
                MessageBox.Show("cerramos la conexion");

            }
            return resultado;

        }
        public int SP_ID()
        {
            AbrirConexion();
            comando = new SqlCommand("PROXIMO_ID", coneccion);

            comando.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@Proximo_id", SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            
            comando.ExecuteNonQuery();
            //Obtenemos el valor del parámetro de salida:
            int ultimoID = Convert.ToInt32(param.Value);
            
            CerrarConexion();
            return ultimoID;
        }
        public DataTable ConsultarTabla(string nombre)
        {
            DataTable dt = new DataTable();
            AbrirConexion();
            comando.CommandText = $"select * from {nombre} order by 1";
            dt.Load(comando.ExecuteReader());
            CerrarConexion();
            return dt;


           
        }
        public void CerrarConexion() { 
            coneccion.Close(); 
        }
    }


   
}
