namespace TemplateMethod.Impostos
{
    public class IKCC : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100(orcamento);
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.04;
        }
        
        private bool TemItemMaiorQue100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100) 
                    return true;
            }
            return false;
        }
    }
}
