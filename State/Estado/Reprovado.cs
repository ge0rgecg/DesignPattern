using System;

namespace State.Estado
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Orçamentos reprovados não recebem desconto extra!");
        }
        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento reprovado, não é possivle aprovar!");
        }
        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento reprovado!");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
