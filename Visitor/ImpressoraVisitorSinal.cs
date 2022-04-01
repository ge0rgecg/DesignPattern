using System;
using Visitor.Expressao;

namespace Visitor
{
    public class ImpressoraVisitorSinal:IVisitor
    {
        public void VisitaSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("+");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);          
            Console.Write(")");
        }

        public void VisitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write("-");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            Console.Write("*");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaDivisao(Divisao divisao)
        {
            Console.Write("(");
            Console.Write("/");
            divisao.Esquerda.Aceita(this);
            Console.Write(" ");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void VisitaNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
