using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco1_3
{
    public class Cuenta
    {
        Random random = new Random();
        public string cbu { get; set; }
        public double saldo { get; set; }
        public  TipoCuenta tipo  { get; set; }
        public int ultimoMovimiento { get; set; }
        
        

        public Cuenta()
        {
            saldo = 0;
            ultimoMovimiento = 0;
            cbu = GenerarNumeroAleatorio(random, 6);
        }
        static string GenerarNumeroAleatorio(Random random, int longitud)
        {
            const string caracteresPermitidos = "0123456789";
            char[] resultado = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                resultado[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(resultado);
        }
    }
}









    
