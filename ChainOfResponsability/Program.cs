using ChainOfResponsability.Contas;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento();
            orcamento.AdicionarItem(new Item("Lapis", 100));
            
            var desconto = calculadorDeDescontos.Calcula(orcamento);
            Console.WriteLine("O desconto para a quantidade " + orcamento.Itens.Count + " de itens é de " + desconto);

            orcamento.AdicionarItem(new Item("Caneta", 200));

            desconto = calculadorDeDescontos.Calcula(orcamento);
            Console.WriteLine("O desconto para a quantidade " +orcamento.Itens.Count +" de itens é de " + desconto);

            orcamento.AdicionarItem(new Item("PC", 300));

            desconto = calculadorDeDescontos.Calcula(orcamento);
            Console.WriteLine("O desconto para a quantidade " + orcamento.Itens.Count + " de itens é de " + desconto);

            orcamento.AdicionarItem(new Item("Carro", 400));
            orcamento.AdicionarItem(new Item("Casa", 500));

            desconto = calculadorDeDescontos.Calcula(orcamento);
            Console.WriteLine("O desconto para a quantidade " + orcamento.Itens.Count + " de itens é de " + desconto);


            Conta conta = new Conta(500, "John");
            Requisicao csv = new Requisicao(Formato.CSV);
            Requisicao xml = new Requisicao(Formato.XML);
            Requisicao percent = new Requisicao(Formato.PORCENTO);
            Requisicao semFormato = new Requisicao(Formato.None);

            ImpressoraRespostas impressoraRespostas = new ImpressoraRespostas();
            impressoraRespostas.Imprime(csv, conta);
            impressoraRespostas.Imprime(xml, conta);
            impressoraRespostas.Imprime(percent, conta);
            impressoraRespostas.Imprime(semFormato, conta);


        }
    }
}
