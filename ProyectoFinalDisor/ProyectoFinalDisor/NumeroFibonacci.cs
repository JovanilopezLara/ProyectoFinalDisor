using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDisor
{
    public class NumeroFibonacci : Metodos
    {
        private int numeroAnterior;
        private int numeroAnteriorAnterior;
        private int numeroActual;
        private int vecesActualizado;
        private int valor;
        private String convert;

        

        public NumeroFibonacci()
        {

            this.vecesActualizado = 0;
            this.numeroAnterior = 0;
            this.numeroAnteriorAnterior = 0;
            this.numeroActual = 0;
            this.valor = 0;

        }
        public int Valor
        {
            get
            {
                return this.valor;
            }
        }

        public String getConvert()
        {
            return this.convert;
        }


        public void incrementar()
        {
            if (this.vecesActualizado == 0)
            {
                this.numeroAnterior = 0;
                this.numeroAnteriorAnterior = 0;
                this.numeroActual = 1;
            }
            if (this.vecesActualizado == 1)
            {
                this.numeroAnterior = 1;
                this.numeroAnteriorAnterior = 0;
                this.numeroActual = 1;
            }
            if (this.vecesActualizado >= 2)
            {
                this.numeroAnteriorAnterior = this.numeroAnterior;
                this.numeroAnterior = this.numeroActual;
                this.numeroActual = this.numeroAnterior + this.numeroAnteriorAnterior;
            }
            this.valor = this.numeroActual;
            this.vecesActualizado += 1;

        }

        public void decrementar()
        {
            try
            {
                if (this.vecesActualizado > 0)
                {
                    if (this.vecesActualizado == 1)
                    {
                        this.numeroActual = this.numeroAnterior;
                        this.numeroAnterior = 0;
                        this.numeroAnteriorAnterior = -1;
                    }

                    if (this.vecesActualizado >= 2)
                    {
                        int respaldoTerminoActual = this.numeroActual;
                        this.numeroActual = respaldoTerminoActual - this.numeroAnteriorAnterior;
                        this.numeroAnterior = this.numeroAnteriorAnterior;
                        this.numeroAnteriorAnterior = this.numeroActual - this.numeroAnterior;
                    }
                    this.valor = this.numeroActual;
                    this.vecesActualizado -= 1;
                }
                else throw new System.InvalidOperationException();
            }
            catch
            {
                throw new System.InvalidOperationException();
            }

        }
        public void reinicio()
        {


            this.numeroAnterior = 0;
            this.numeroAnteriorAnterior = 0;
            this.numeroActual = 0;
            this.vecesActualizado = 0;
            this.valor = 0;


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

