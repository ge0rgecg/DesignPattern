using System;

namespace Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;

        public MensagemAdministrativa(string nome)
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
            return $"Mensagem enviada para o administrador {nome}";
        }
    }
}
