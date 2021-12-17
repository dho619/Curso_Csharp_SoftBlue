using System;

namespace Aula_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IMototorizado
    {
        string NomeMotor { get; set; }
        void Ligar();
        void Desligar();
    }

    public class Carro : IMototorizado
    {
        public string NomeMotor { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
