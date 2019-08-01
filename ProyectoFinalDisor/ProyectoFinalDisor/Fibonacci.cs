using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDisor
{
    class Fibonacci : Metodos
    {
        private int numeroAnterior;
        private int numeroActual;
        private int VecesActualizado;
        private int valor;

        public Fibonacci()
        {
            this.numeroActual = 0;
            this.numeroAnterior = 0;
            this.valor = 0;
            this.VecesActualizado = 0;
        }


        public int Valor
        {
            get
            {
                return this.valor;
            }
        }

        public void incrementar()
        {
            this.numeroAnterior = this.numeroActual;
            this.numeroActual += 2;
            this.valor = this.numeroActual;
        }

        public void decrementar()
        {
            this.numeroAnterior = this.numeroActual;
            this.numeroActual -= 2;
            this.valor = this.numeroActual;
        }

        public void Incrementar()
        {
            throw new NotImplementedException();
        }

        public void Decrementar()
        {
            throw new NotImplementedException();
        }
    }
}
