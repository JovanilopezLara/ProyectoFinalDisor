using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDisor
{
    class SistemaNumerico
    {
        public SistemaNumerico()
        {
        }

        public string Binario(Metodos objeto)
        {
            return Convert.ToString(objeto.Valor, 2);
        }

        public string Hexadecimal(Metodos objeto)
        {
            return Convert.ToString(objeto.Valor, 16);
        }
    }
}
