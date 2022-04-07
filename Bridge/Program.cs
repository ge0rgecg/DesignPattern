using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemCliente("Josh");
            IEnviador enviador = new EnviaPorSms();
            mensagem.enviador = enviador;
            mensagem.Envia();
        }
    }
}
