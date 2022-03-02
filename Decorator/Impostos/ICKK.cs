namespace Decorator.Impostos
{
    public class ICKK : TemplateDeImpostoCondicional
    {
        public ICKK(Imposto outroImposto) : base(outroImposto) { }
        public ICKK() : base() { }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.03;
        }
    }
}
