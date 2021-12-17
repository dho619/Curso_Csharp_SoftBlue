using System;

namespace Aula_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro a = new Cachorro();
            a.Peso = 4;
            a.Altura = 0.8;
            //a.nome = "Jorge";//não consegue acessar por aki
            a.Mover();
            a.MostrarDados();
            a.Latir();
            Console.WriteLine(a);
        }
    }
}
