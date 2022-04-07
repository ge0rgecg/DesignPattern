using System;

namespace Bridge
{
    public class EnviaPorSms : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Mensagem enviada por sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
