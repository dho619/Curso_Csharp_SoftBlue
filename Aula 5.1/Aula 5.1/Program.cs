using System;

namespace Aula_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bola b1 = new Bola();
            Bola b2 = new Bola();
            Bola b3 = new Bola();
            Bola.ImprimeNumBolas();

            Console.WriteLine("----------------------------------");

            Cambio c1 = new Cambio();
            //Console.WriteLine(Cambio.cotacaoDolar);

            Console.WriteLine("----------------------------------");

            Console.WriteLine(Matematica.pi);
            //Matematica.pi = 0; //não funciona pq é constante
            //Console.WriteLine(Matematica.e);//não funciona, pois "e" pertence a objeto

        }
    }

    class Bola
    {
        public static int numBolas;

        public Bola()
        {
            numBolas++;
        }

        public static void ImprimeNumBolas()
        {
            Console.WriteLine(numBolas);
            //métodos static não tem acesso a fields dos objetos
            //métodos não static tem acesso a fields da classe(statics)
        }
    }

    class Cambio
    {
        public static double cotacaoDolar;

        static Cambio() //feito pra inicializar fields statics, executa uma única vez quando for referenciado a classe (vai ser o primeiro a ser executado)
        {
            Console.WriteLine("Construtor static foi chamado");
            cotacaoDolar = 2.1;
        }
    }

    class Matematica
    {
        public const double pi = 3.1416; //field const vira static
                                         //const é necessário que use valor constante e não variáveis
        public readonly double e = 2.71828; //field só leitura, parecido com o const, mas não é static
    }
}
