using System;

namespace Observer
{
    public class EnviadorDeEmail:IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por email");
        }
    }
}
