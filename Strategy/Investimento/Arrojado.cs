using System;

namespace Strategy.Impostos
{
    public class Arrojado : IInvestimento
    {
        private Random random;
        public Arrojado()
        {
            random = new Random();
        }
        public double Investir(Conta conta)
        {
            var chance = random.Next(0, 101);

            if (chance <= 20)
            {
                return conta.Saldo * 0.05;
            }
            else 
            {
                if(chance > 20 && chance <= 50)
                {
                    return conta.Saldo * 0.03;
                }
                else
                {
                    return conta.Saldo * 0.006;
                }
            }
        }
    }
}
