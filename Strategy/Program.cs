using Strategy.Impostos;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Orcamento orcamento = new Orcamento(500);
            Conta conta = new Conta();
            conta.Deposita(1000);

            IImposto ISS = new ISS();
            IImposto ICMS = new ICMS();
            IImposto ICCC = new ICCC();

            CalculadorDeImposto calculadorDeImposto = new CalculadorDeImposto();

            calculadorDeImposto.Imprime(ISS, orcamento);
            calculadorDeImposto.Imprime(ICMS, orcamento);
            calculadorDeImposto.Imprime(ICCC, orcamento);

            IInvestimento conservador = new Conservador();
            IInvestimento moderado = new Moderado();
            IInvestimento arrojado = new Arrojado();

            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();

            realizadorDeInvestimentos.Imprime(conservador, conta);
            realizadorDeInvestimentos.Imprime(moderado, conta);
            realizadorDeInvestimentos.Imprime(arrojado, conta);

        }
    }
}
