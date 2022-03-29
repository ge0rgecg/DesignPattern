namespace Visitor.Expressao
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorDireita == 0 ? 0 : valorEsquerda / valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeDivisao(this);
        }
    }
}