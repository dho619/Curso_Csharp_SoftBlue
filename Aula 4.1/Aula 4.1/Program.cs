using System;

namespace Aula_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            int i = 5;
            m.Trocar(i);
            Console.WriteLine(i);
            m.Trocar(ref i);
            Console.WriteLine(i);

            Console.WriteLine("\n*******************");
            Numero num = new Numero();
            num.n = 5;
            m.Mudar(num);
            Console.WriteLine(num.n);
            m.Mudar(ref num);
            Console.WriteLine(num.n);

            Console.WriteLine("\n*******************");
            int res;
            m.Multiplicar(10, 2, out res);
            Console.WriteLine(res);

            Console.WriteLine("\n*******************");
            Console.WriteLine(m.Elevar(2, 3));
            Console.WriteLine(m.Elevar(2));

            Console.WriteLine("\n*******************");
            int n1 = 10;
            //int n2 = null;
            int? n2 = null;
            //if (n2 == null) or
            if ( !n2.HasValue)
            {
                Console.WriteLine("Valor é nulo");
            }
            int n3 = n2 ?? 0; //se for nulo coloca o 0
            Console.WriteLine(n3);

            Console.WriteLine("\n*******************");

            Ponto p = new Ponto();
            p.x = 10;
            p.y = 12;
            p.ExibirCoordenadas();
        }
    }

    class MyClass
    {
        public void Trocar(int x)
        {
            x = 10;
        }
        public void Trocar(ref int x)
        {
            x = 10;
        }
        public void Mudar(Numero x)
        {
            x.n = 10;
        }
        public void Mudar(ref Numero x)
        {
            x.n = 10;
        }

        public void Multiplicar(int a, int b, out int c)
        {
            c = a * b;
        }

        public double Elevar(double n, double pot = 2)
        {
            return Math.Pow(n, pot);
        }
    }

    class Numero
    {
        public int n = 10;
    }

    struct Ponto
    {
        public int x;
        public int y;

        public void ExibirCoordenadas()
        {
            Console.WriteLine("X = " + x + ", y = " + y);
        }
    }
}
