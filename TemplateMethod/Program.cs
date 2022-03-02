using System;
using TemplateMethod.Impostos;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Orçamento 1");


            Orcamento orcamento = new();
            orcamento.AdicionarItem(new("Lapis", 100));
            orcamento.AdicionarItem(new("Borracha", 50));
            orcamento.AdicionarItem(new("Caneta", 400));
            
            IImposto ISS = new ISS();
            IImposto ICMS = new ICMS();
            IImposto IKCC = new IKCC();
            IImposto ICKK = new ICKK();
            IImposto IHIT = new IHIT();

            CalculadorDeImposto calculadorDeImposto = new();

            calculadorDeImposto.Imprime(ISS, orcamento);
            calculadorDeImposto.Imprime(ICMS, orcamento);
            calculadorDeImposto.Imprime(IKCC, orcamento);
            calculadorDeImposto.Imprime(ICKK, orcamento);
            calculadorDeImposto.Imprime(IHIT, orcamento);

            Console.WriteLine("Orçamento 2");
            orcamento = new();
            orcamento.AdicionarItem(new("Lapis", 100));
            orcamento.AdicionarItem(new("Lapis", 100));
            orcamento.AdicionarItem(new("Lapis", 100));
            orcamento.AdicionarItem(new("Lapis", 100));
            orcamento.AdicionarItem(new("Lapis", 100));
            orcamento.AdicionarItem(new("Borracha", 50));
            

            calculadorDeImposto.Imprime(ISS, orcamento);
            calculadorDeImposto.Imprime(ICMS, orcamento);
            calculadorDeImposto.Imprime(IKCC, orcamento);
            calculadorDeImposto.Imprime(ICKK, orcamento);
            calculadorDeImposto.Imprime(IHIT, orcamento);

        }
    }
}
