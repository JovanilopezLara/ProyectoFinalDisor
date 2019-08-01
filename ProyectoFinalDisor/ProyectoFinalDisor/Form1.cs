using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDisor
{
    public partial class Form1 : Form
    {
        Boton avanzar;
        Boton retroceder;
        Texto binario;
        Texto hexadecimal;
        Texto valor;
        Label labelBinario;
        Label labelHexa;
        Texto español;
        Texto binarioSuerte;
        Texto hexadeximalSuerte;
        Texto españolSuerte;
        Texto binarioPadovan;
        Texto hexadeximalPadovan;
        Texto españolPadovan;
        Texto binarioUlam;
        Texto hexadeximallUlam;
        Texto españolUlam;


        NumeroFibonacci f;
        SistemaNumerico metodos;

        public Form1()
        {
            InitializeComponent();

            avanzar = new Boton("Incrementar");
            retroceder = new Boton("Decrementar");
            valor = new Texto("");
            binario = new Texto("");
            hexadecimal = new Texto("");
            español = new Texto("");
            //españolSuerte = new Texto("");
            //binarioSuerte = new Texto("");
            //hexadeximalSuerte = new Texto("");
            //españolPadovan = new Texto("");
            //binarioPadovan = new Texto("");
            //hexadeximalPadovan = new Texto("");
           // españolUlam = new Texto("");
           // binarioUlam = new Texto("");
         //   hexadeximallUlam = new Texto("");
           


            avanzar.Location = new Point(500, 300);
            retroceder.Location = new Point(100, 300);
            
            binario.Location = new Point(90, 110);
            hexadecimal.Location = new Point(90, 180);
            español.Location = new Point(90, 240);

            valor.Location = new Point(90, 50);
            valor.Text = "0";

            metodos = new SistemaNumerico();
            f = new NumeroFibonacci();

            avanzar.Click += avanzar_click;
            retroceder.Click += retroceder_click;

            this.Controls.Add(avanzar);
            this.Controls.Add(retroceder);
            this.Controls.Add(binario);
            this.Controls.Add(hexadecimal);
            this.Controls.Add(valor);
            this.Controls.Add(español);
        }

        private void avanzar_click(object sender, EventArgs e)
        {
            f.incrementar();
            valor.Text = Convert.ToString(f.Valor);
            binario.Text = metodos.Binario(f);
            hexadecimal.Text = metodos.Hexadecimal(f);
        }

        private void retroceder_click(object sender, EventArgs e)
        {

            f.decrementar();
            valor.Text = Convert.ToString(f.Valor);
            binario.Text = metodos.Binario(f);
            hexadecimal.Text = metodos.Hexadecimal(f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
