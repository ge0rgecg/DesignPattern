using System;

namespace State.Estado
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Orçamentos finalizado não recebem desconto extra!");
        }
        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está finalizado!");
        }
        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está finalizado!");
        }
        public void Finaliza(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento já está finalizado");
        }
    }
}
