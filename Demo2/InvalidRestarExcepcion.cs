using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class InvalidRestarExcepcion: Exception
    {
        public InvalidRestarExcepcion() : base("Error: Segundo Número No Válido") { }
    }
}
