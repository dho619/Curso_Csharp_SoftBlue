using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_04
{
    class ContaBancaria
    {
        public string titular;
        public int numConta;
        public double saldo;

        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Transferir(double valor, ContaBancaria contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }

    }
}
