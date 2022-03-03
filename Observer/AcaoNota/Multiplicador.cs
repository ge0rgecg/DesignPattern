using System;

namespace Observer
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }
        public Multiplicador(double fator)
        {
            Fator = fator;
        }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"Valor da nota multiplicado por {Fator} é {Fator* nf.ValorBruto}");
        }
    }
}
