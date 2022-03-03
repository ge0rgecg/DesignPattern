using System;

namespace State.Estado
{
    public class Aprovado:IEstadoDeUmOrcamento
    {
        public Aprovado(bool gerouDesconto) {
            GerouDesconto = gerouDesconto;
        }
        private bool GerouDesconto { get; set; }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (GerouDesconto) Console.WriteLine("Já foi dado desconto nesse orçamento");
            orcamento.Valor -= orcamento.Valor * 0.02;
            GerouDesconto = true;
        }
        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já aprovado!");
        }
        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento esta aprovado, não pode ser reprovado!");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
