using System;

namespace Aula_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario s1 = new Salario(2000, .2);
            Salario s2 = new Salario(1000, .4, 2);
            s1.MostrarValor();
            s2.MostrarValor();
        }
    }

    class Salario
    {
        public double valor;
        public int mes;

        public Salario(Double valor, double bonus)
        {
            Console.WriteLine("Construindo Objeto (1)");
            this.valor = valor + valor * bonus;
        }

        //public Salario(Double valor, double bonus, int mes)
        //{
        //    Console.WriteLine("Construindo Objeto (2)");
        //    this.valor = valor + valor * bonus;
        //    this.mes = mes;
        //}

        public Salario(Double valor, double bonus, int mes): this(valor, bonus) //chama o outro construtor
        {
            Console.WriteLine("Construindo Objeto (2)");
            this.mes = mes;
        }

        public void MostrarValor()
        {
            Console.WriteLine(valor);
        }
    }
}
