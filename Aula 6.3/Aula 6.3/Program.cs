using System;

namespace Aula_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerenciador g1 = new Gerenciador();
            Gerenciador g1 = Gerenciador.Instace;
            Gerenciador g2 = Gerenciador.Instace;// vai referenciar o mesmo do g1, pois apenas cria um
        }
    }
}
