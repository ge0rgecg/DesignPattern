﻿using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

        public NotaFiscal(
            string razaoSocial, string cnpj, DateTime data, double valorBruto, double impostos,
            IList<ItemDaNota> itens, string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataEmissao = data;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;
        }
    }
}
