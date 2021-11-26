namespace ChainOfResponsability.Contas
{
    public class Conta
    {
        public double Saldo { get; set; }
        public string Nome { get; set; }
        public Conta(double saldo, string nome)
        {
            Saldo = saldo;
            Nome = nome;
        }
    }
}
