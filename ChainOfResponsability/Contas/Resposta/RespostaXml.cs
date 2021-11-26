using System;

namespace ChainOfResponsability.Contas.Resposta
{
    public class RespostaXml:IResposta
    {
        public RespostaXml(IResposta proximo = null)
        {
            Next = proximo;
        }
        public void Responde(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<Conta><Titular>" + conta.Nome + "</Titular><Saldo>" + conta.Saldo + "</Saldo></Conta>");
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
