namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido("John", 100);
            Pedido pedido2 = new Pedido("Mary", 500);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }
}
