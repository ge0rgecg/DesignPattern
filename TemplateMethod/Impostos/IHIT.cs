using System.Linq;
namespace TemplateMethod.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(g => g.Nome).Any(a => a.Count() > 2);
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
        
    }
}
