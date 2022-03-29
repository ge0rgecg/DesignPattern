namespace Visitor.Expressao
{
    public interface IExpressao
    {
        public int Avalia();

        void Aceita(IVisitor impressora);
    }
}
