using ChainOfResponsability.Desconto;
using System.Linq;

namespace ChainOfResponsability
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if(orcamento.Itens.Any(a => a.Nome.Equals("Lapis")) && orcamento.Itens.Any(a => a.Nome.Equals("Caneta")))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }
    }
}