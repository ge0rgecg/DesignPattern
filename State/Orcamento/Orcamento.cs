using State.Estado;

namespace State
{
    public class Orcamento
    {

        public IEstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get; set; }

        public Orcamento(double valor)
        {
            EstadoAtual = new EmAprovacao();
            Valor = valor;
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}