using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase13
{
    public class InvalidNoteExcepcion : Exception
    {
        //base: Hace referencia al constructor del padre
        public InvalidNoteExcepcion(): base("Nota Inválida") { }
    }
  
}
