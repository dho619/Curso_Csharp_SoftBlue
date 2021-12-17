using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_7
{
    class Animal
    //sealed class Animal
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        protected string nome;

        public void Mover()
        {
            Console.WriteLine("Animal de nome " + nome + ", se Moveu");
        }

        public void MostrarDados()
        {
            Console.WriteLine("Altura = " + Altura + ", Peso = " + Peso);
        }
    }
}
