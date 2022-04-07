using System;

namespace Bridge
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Mensagem enviada por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
