namespace Visitor.Expressao
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda{get; set;}
        public IExpressao Direita { get; set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda * valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.VisitaMultiplicacao(this);
        }
    }
}