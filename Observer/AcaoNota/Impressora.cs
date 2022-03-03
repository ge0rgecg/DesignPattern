using System;

namespace Observer
{
    public class Impressora : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Imprimindo notaFiscal");
        }
    }
}
