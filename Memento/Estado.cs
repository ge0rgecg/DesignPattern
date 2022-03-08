using System;

namespace Memento
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }
        public DateTime Data { get; private set; }
        public Estado ( Contrato contrato)
        {
            Contrato = contrato;
            Data = DateTime.Now;
        }
    }
}
