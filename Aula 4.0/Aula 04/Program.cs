using System;

namespace Aula_04
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria();
            conta1.numConta = 4578;
            conta1.titular = "João";
            ContaBancaria conta2 = new ContaBancaria();
            conta2.numConta = 4575;
            conta2.titular = "Marcos";

            conta1.Depositar(200);
            conta1.Sacar(20);
            conta1.Transferir(100, conta2);

            Console.WriteLine(conta1.titular + " dono da conta número " + conta1.numConta + ", possui saldo igual a R$" + conta1.saldo);
            Console.WriteLine(conta2.titular + " dono da conta número " + conta2.numConta + ", possui saldo igual a R$" + conta2.saldo);
            
        }
    }
}
