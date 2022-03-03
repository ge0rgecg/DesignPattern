using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAcao = new List<IAcaoAposGerarNota>();
            listaAcao.Add(new EnviadorDeEmail());
            listaAcao.Add(new NotaFiscalDao());
            listaAcao.Add(new EnviadorDeSms());
            listaAcao.Add(new Impressora());
            listaAcao.Add(new Multiplicador(7));
            listaAcao.Add(new Multiplicador(2));
            listaAcao.Add(new Multiplicador(5));
            NotaFiscalBuilder builder = new NotaFiscalBuilder(listaAcao);
            

            NotaFiscal nf = builder
                .ParaEmpresa("Minha empresa")
                .ComCnpj("12.123.123/0001-01")
                .ComItem(new ItemDaNotaBuilder().ParaItem("item 1").ComValor(100).Controi())
                .ComItem(new ItemDaNotaBuilder().ParaItem("item 2").ComValor(200).Controi())
                .ComItem(new ItemDaNotaBuilder().ParaItem("item 3").ComValor(300).Controi())
                .ComObservacoes("entregar pessoalmente")
                .NaDataAtual()
                .Constroi();
        }
    }
}
