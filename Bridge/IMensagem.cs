namespace Bridge
{
    public interface IMensagem
    {
        public IEnviador enviador { get; set; }
        public void Envia();
        public string Formata();
    }
}
