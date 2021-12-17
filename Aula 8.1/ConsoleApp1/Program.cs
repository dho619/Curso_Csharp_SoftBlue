using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c = new Cachorro();
            c.Falar();
            c.Rolar();

            Animal a = new Cachorro();
            a.Falar(); //Irá chamar o método falar do cachorro, pois é o que está na memória
            //a.Rolar(); //Da erro, pois o que define o que pode ser chamado é o tipo da variável (Animal)
            Cachorro c2 = (Cachorro)a;
            c2.Rolar();
        }
    }
}

public abstract class Animal
{
    public abstract void Falar();
}

public class Cachorro : Animal
{
    public override void Falar()
    {
        Console.WriteLine("Au-Au");
    }

    public void Rolar()
    {
        Console.WriteLine("(cachorro rolando...)");
    }
}
public class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("Miau");
    }
}