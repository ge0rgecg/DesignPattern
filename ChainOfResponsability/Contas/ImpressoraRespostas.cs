using ChainOfResponsability.Contas.Resposta;

namespace ChainOfResponsability.Contas
{
    public class ImpressoraRespostas
    {
        public void Imprime(Requisicao requisicao, Conta conta)
        {
            IResposta r1 = new RespostaEmCsv();
            IResposta r2 = new RespostaEmPorcento(r1);
            IResposta r3 = new RespostaXml(r2);

            r3.Responde(requisicao, conta);
        }
    }
}
