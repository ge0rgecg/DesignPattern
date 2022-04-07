using System;

namespace Bridge
{
    public class MensagemCliente : IMensagem
    {
        private string nome;

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }

        public IEnviador enviador { get; set; }

        public void Envia()
        {
            this.enviador.Envia(this);
        }

        public string Formata()
        {
            return $"Mensagem enviada para o cliente {nome}";
        }
    }
}
