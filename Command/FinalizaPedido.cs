using System;

namespace Command
{
    public class FinalizaPedido : ICommand
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Execute()
        {
            Console.WriteLine($"Pedido do {pedido.Cliente} finalizado!");
            pedido.Finaliza();
        }
    }
}
