using TemplateMethod.Impostos;
using System;

namespace TemplateMethod
{
    public class CalculadorDeImposto
    {
        public void Imprime(IImposto imposto, Orcamento orcamento)
        {
            Console.WriteLine("O valor do imposto é de R$" + imposto.Calcula(orcamento));
        }
    }
}
