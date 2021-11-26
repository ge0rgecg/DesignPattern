using System;

namespace ChainOfResponsability.Contas.Resposta
{
    public class RespostaEmPorcento : IResposta
    {
        public RespostaEmPorcento(IResposta proximo = null)
        {
            Next = proximo;
        }
        public void Responde(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Nome + "%" + conta.Saldo);
            }
            else
            {
                if (Next != null)
                {
                    Next.Responde(requisicao, conta);
                }
            }
        }
        public IResposta Next { get; private set; }
    }
}
