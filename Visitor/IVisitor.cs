using Visitor.Expressao;

namespace Visitor
{
    public interface IVisitor
    {
        public void ImprimeSoma(Soma soma);
        public void ImprimeSubtracao(Subtracao subtracao);
        public void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        public void ImprimeDivisao(Divisao divisao);
        public void ImprimeNumero(Numero numero);
    }
}
