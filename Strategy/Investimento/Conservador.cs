namespace Strategy.Impostos
{
    public class Conservador : IInvestimento
    {
        public double Investir(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
