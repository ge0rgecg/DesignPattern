using Decorator.Impostos;
using System;

namespace Decorator
{
    public class CalculadorDeImposto
    {
        public void Imprime(Imposto imposto, Orcamento orcamento)
        {
            Console.WriteLine("O valor do imposto é de R$" + imposto.Calcula(orcamento));
        }
    }
}
