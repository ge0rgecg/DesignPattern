using System;

namespace Command
{
    public class PagaPedido : ICommand
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Execute()
        {
            Console.WriteLine($"Pedido do {pedido.Cliente} no valor de {pedido.Valor} reais foi pago!");
            pedido.Paga();
        }
    }
}
