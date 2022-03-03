using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NotaFiscal nf = new NotaFiscalBuilder()
                .ParaEmpresa("Minha empresa")
                .ComCnpj("12.123.123/0001-01")
                .ComItem(new ItemDaNotaBuilder().ParaItem("item 1").ComValor(100).Controi())
                .ComItem(new ItemDaNotaBuilder().ParaItem("item 2").ComValor(200).Controi())
                .ComItem(new ItemDaNotaBuilder().ParaItem("item 3").ComValor(300).Controi())
                .ComObservacoes("entregar pessoalmente")
                .NaDataAtual()
                .Constroi();

            Console.WriteLine($"Nota com valor {nf.ValorBruto} e total de impostos em {nf.Impostos}");
        }
    }
}
