using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDisor
{
    class Texto : TextBox
    {
        
        
            public Texto(string v)
            {

            }

            public void ActualizarEntrada(string valor)
            {
                this.Text = valor;
            }
        }
    }
