using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDisor
{
    class Capicua
    {
        private String numero;
        private String valor;
        private Boolean estado;
        public Capicua()
        {
            this.numero = "";
            this.valor = "";
            this.estado = false;
        }
        public void verificarNumeroCapicua()
        {



            for (int i = 0; i < numero.Length; i++)
            {
                valor = numero.Substring(i, 1) + valor;
            }
            if (valor == numero)
            {
                estado = true;
            }
            
        }
    }
}
