using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AppBanco1_3
{
    public class TipoCuenta
    {
        public string nombre { get; set; }

        public int id { get; set; }

        public TipoCuenta(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;

        }
    }
}
