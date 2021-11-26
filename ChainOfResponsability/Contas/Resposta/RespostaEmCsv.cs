using System;

namespace ChainOfResponsability.Contas.Resposta
{
    public class RespostaEmCsv : IResposta
    {
        public RespostaEmCsv(IResposta proximo = null)
        {
            Next = proximo;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Nome + ";" + conta.Saldo);
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
