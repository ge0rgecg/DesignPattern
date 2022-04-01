using Visitor.Expressao;

namespace Visitor
{
    public interface IVisitor
    {
        public void VisitaSoma(Soma soma);
        public void VisitaSubtracao(Subtracao subtracao);
        public void VisitaMultiplicacao(Multiplicacao multiplicacao);
        public void VisitaDivisao(Divisao divisao);
        public void VisitaNumero(Numero numero);
    }
}
