namespace Decorator.Impostos
{
    public class IHIGH : Imposto
    {
        public IHIGH(Imposto outroImposto) : base(outroImposto) { }
        public IHIGH() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
