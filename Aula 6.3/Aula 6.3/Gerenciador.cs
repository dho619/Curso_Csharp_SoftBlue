using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_6
{
    class Gerenciador
    {
        private static readonly Gerenciador instance = new Gerenciador();

        public static Gerenciador Instace
        {
            get
            {
                return instance;
            }
        }

        private Gerenciador()
        {
        }

        public void Gerenciar()
        {

        }

    }
}
