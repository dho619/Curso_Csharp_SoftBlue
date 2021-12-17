using System;

namespace Aula_6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco e = new Endereco();
            //e.logradouro = "R. dos Programadores"; Não pode acessar o field pq é private
            e.Logradouro = "R. dos Programadores";
            e.Numero = 26;
            e.Apartamento = true;


            Contato c1 = new Contato { Nome = "José Silva", Email="Exemplo@hotmail.com", Endereco="R. dos Peixes", Telefone="35 98989898" };
            Contato c2 = new Contato("Pedro") { Email="Exemplo@hotmail.com", Endereco="R. dos Peixes", Telefone="35 98989898" };

            c1.MostraInfo();
            c2.MostraInfo();
        }
    }

    class Endereco
    {
        private string logradouro;
        private int numero;
        //private bool apartamento;
        public bool Apartamento { private get; set; }//forma de declarar propertis com uma só linha (de leitura e escrita e simples)
        
        public string Logradouro { //posso omitir o get ou o set, fazendo virar readonly ou writeonly (apenas ler, apenas escrita)
            get {
                return logradouro;
            }
            set
            {
                if (value != null)
                {
                    this.logradouro = value;
                }
            }
        }

        public int Numero
        {
            get => numero;
            set => this.numero = value;
        }
    }

    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Contato()
        {
            Console.WriteLine("Contato()");
        }
        
        public Contato(string nome)
        {
            Console.WriteLine("Contato(string)");
            this.Nome = nome;
        }

        public void MostraInfo()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Endereco: " + Endereco);
        }

    }
}
