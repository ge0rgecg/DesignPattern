using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> totalItens = new List<ItemDaNota>();
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas;

        public NotaFiscalBuilder(List<IAcaoAposGerarNota> listaAcao)
        {
            this.todasAcoesASeremExecutadas = listaAcao;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal =
                new(RazaoSocial, Cnpj, Data, valorTotal, impostos, totalItens, Observacoes);

            foreach (var acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            totalItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);
        }
    }
}
