using System.Collections.Generic;
using System.Linq;

namespace ChainOfResponsability
{
    public class Orcamento
    {
        public List<Item> Itens { get; set; }

        public double Valor { get { return Itens.Sum(s => s.Valor); } }

        public Orcamento()
        {
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}