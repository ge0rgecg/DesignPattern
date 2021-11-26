namespace Strategy
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}
