using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AppBanco1_3
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

       public List<Cuenta> lista { get ; set; }

        public Cliente()
        {
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.DNI = 0;
            lista = new List<Cuenta>();
        }
        public Cliente(string Nombre,string Apellido,int DNI)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }
    }
}
