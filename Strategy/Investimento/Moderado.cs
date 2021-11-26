using System;

namespace Strategy.Impostos
{
    public class Moderado : IInvestimento
    {
        private Random random;
        public Moderado()
        {
            random = new Random();
        }
        public double Investir(Conta conta)
        {
            if (random.Next(0, 101) <= 50)
            {
                return conta.Saldo * 0.025;
            }

            return conta.Saldo * 0.007;
        }
    }
}
