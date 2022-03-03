namespace Builder
{
    public class ItemDaNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota Controi()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder ParaItem(string nome)
        {
            this.Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}
