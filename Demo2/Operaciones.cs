using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Operaciones
    {
        private int valor1;
        private int valor2;

        public void AsignarValores(int pvalor1, int pvalor2)
        {
            valor1 = pvalor1;
            valor2 = pvalor2;
        }
        public int Sumar()
        {
            return valor1 + valor2;
        }
        public int Restar()
        {           
            if (valor2 > valor1)
                throw new InvalidRestarExcepcion();

            return valor1 - valor2;
        }
        public decimal Dividir()
        {

           return valor1 / valor2;                       
        }

    }
}
