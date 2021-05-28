using System;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Variaveis e Constantes */
            int num;
            double nota;

            num = 5;
            nota = 9.5;

            num = num + 10;
            double nota2 = nota / 2;

            //Console.WriteLine(num);
            //Console.WriteLine(nota);
            //Console.WriteLine(nota2);

            const double pi = 3.1416;

            //pi = 3.14; não pode mudar o valor de constante

            /* Casting */

            int i = 10;
            double d = i;

            short s = 5;
            long l = s;

            //int j = d; não pode
            int j = (int) d;
            int x = (int) 3.5;

            long l2 = 75124512321312314;
            int i2 = (int) l2;

            //Console.WriteLine(j);
            //Console.WriteLine(x);
            //Console.WriteLine(i2);

            /* Estruturas de Controle */

            int x2 = 4;

            if (x2>5)
            {
                Console.WriteLine("X maior que 5!");
            }
            else if (x2==5)
            {
                Console.WriteLine("X é igual a 5!");
            }
            else
            {
                Console.WriteLine("X menor que 5!");
            }


            int mes = 2;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mês tem 31 dias!");
                    break;
                case 2:
                    Console.WriteLine("Mes com 28 dias!");
                    break;
                case 3:
                    Console.WriteLine("Mes com 31 dias!");
                    break;
                default:
                    Console.WriteLine("Olha no calendario!");
                    break;
            }
            Console.WriteLine("***************************\n\n");
            /* Estrutura de repetição */
            int limitador = 0;
            while (limitador < 10)
            {
                Console.WriteLine(limitador);
                limitador++;
                if (limitador>4)
                {
                    break;
                }
            }
            Console.WriteLine("***************************\n");

            do
            {
                limitador++;
                if (limitador == 8)
                {
                    continue;
                }
                Console.WriteLine(limitador);
            } while (limitador < 10);
            Console.WriteLine("***************************\n");

            for (int p = 0; p < 3; p++)
            {
                Console.WriteLine(p);
            }

            //int lista() = [0, 5, 8, 9, 1, 2];

            //foreach (int item in lista)
            //{

            //}

            Console.WriteLine("|Fim do programa!");
        }
    }
}
