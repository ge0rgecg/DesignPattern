using System;

namespace Memento
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string cliente, TipoContrato tipo)
        {
            Data = data;
            Cliente = cliente;
            Tipo = tipo;
        }

        public void Avanca()
        {
            switch (Tipo)
            {
                case TipoContrato.Novo:
                    Tipo = TipoContrato.EmAndamento;
                    break;
                case TipoContrato.EmAndamento:
                    Tipo = TipoContrato.Acertado;
                    break;
                case TipoContrato.Acertado:
                    Tipo = TipoContrato.Concluido;
                    break;
                case TipoContrato.Concluido:
                default:
                    break;
            }
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }

        public void Restaura(Estado estado)
        {
            Data = estado.Contrato.Data;
            Cliente = estado.Contrato.Cliente;
            Tipo = estado.Contrato.Tipo;

        }
    }
}
