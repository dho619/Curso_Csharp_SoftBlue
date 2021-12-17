using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Passaro p = new Passaro();
        }
    }

    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal()");
        }
    }

    class AnimalAlado : Animal
    {
        public AnimalAlado(string teste)
        {
            Console.WriteLine("AnimalAlado() " + teste);
        }
    }

    class Passaro : AnimalAlado
    {
        public Passaro() : base("Vindo de Passaro!")
        {
            Console.WriteLine("Passaro()");
        }
    }
}
