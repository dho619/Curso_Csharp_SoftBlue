using System;

namespace Aula_9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //object o = null;
                //o.ToString();

                double r = Matematica.Dividir(10, 1);
                //double r = Matematica.Dividir(10, 2);
                Console.WriteLine(r);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Ocorreu um erro: Referência Null");
            }
            //catch (ArgumentNullException e) { } //vai dar erro pq tem classes superiores acima (ArgumentNullException é uma subclasse de ArgumentException)
            catch (BurriceException e)
            {
                throw new DivideByZeroException("Só de zoas vou falar que é zero! ", e);
            }
            finally
            {
                Console.WriteLine("Vou executar sempre, pq eu quero!");
            }
        }
    }

    public class Matematica
    {
        public static double Dividir(double n, double d)
        {
            if (d == 0)
            {
                throw new ArgumentException("O denominador não pode ser zero");
            }

            if (d == 1)
            {
                throw new BurriceException("Qualquer número por 1 é ele mesmo pô! (Você mereceu o erro)");
            }

            return n / d;
        }
    }

    public class BurriceException : Exception
    {
        public BurriceException() { }
        public BurriceException(string message) : base(message) { }
        public BurriceException(string message, Exception inner) : base(message, inner) { }
        
    }
}
