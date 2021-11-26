using Strategy.Impostos;
using System;

namespace Strategy
{
    public class CalculadorDeImposto
    {
        public void Imprime(IImposto imposto, Orcamento orcamento)
        {
            Console.WriteLine("O valor do imposto é de R$" + imposto.Calcula(orcamento));
        }
    }
}
