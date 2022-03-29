using System;
using Visitor.Expressao;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            var direita = new Subtracao(new Numero(20), new Numero(10));
            var resultado = new Divisao(new Numero(1000), new Multiplicacao(new Numero(2), new Soma(esquerda, direita)));

            var impressora = new ImpressoraVisitor();
            resultado.Aceita(impressora);
        }
    }
}
