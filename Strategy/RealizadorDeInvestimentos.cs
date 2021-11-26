using Strategy.Impostos;
using System;

namespace Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Imprime(IInvestimento investimento, Conta conta)
        {
            Console.WriteLine("O valor do retorno de investimento é de R$" + investimento.Investir(conta));
        }
    }
}
