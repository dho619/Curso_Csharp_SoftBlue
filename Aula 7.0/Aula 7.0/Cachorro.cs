using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_7
{
    class Cachorro : Animal
    {
        public Cachorro()
        {
            nome = "Dog";
        }
        public void Latir()
        {
           Console.WriteLine("Au au! Meu nome é " + nome);
        }
        public override string ToString()
        {
            return "Objeto de uma classe herdeira de Animal!";
        }
    }
}
