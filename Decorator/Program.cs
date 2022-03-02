using Decorator.Impostos;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto ISS = new ISS(new ICMS(new IHIGH(new ICKK())));

            Orcamento orcamento = new();
            orcamento.AdicionarItem(new("lapis", 500));

            double valor = ISS.Calcula(orcamento);
            
            Console.WriteLine(valor);
        }
    }
}
