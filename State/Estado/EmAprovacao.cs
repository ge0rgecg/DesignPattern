using System;

namespace State.Estado
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public bool GerouDesconto { get; set; }
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (GerouDesconto) Console.WriteLine("Já foi gerado desconto nesse orçamento!");
            orcamento.Valor -= orcamento.Valor * 0.05;
            GerouDesconto = true;
        }
        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado(GerouDesconto);
        }
        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
        public void Finaliza(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento em aprovação não pode ser finalizado!");
        }
    }
}
