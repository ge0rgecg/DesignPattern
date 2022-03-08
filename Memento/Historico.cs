using System.Collections.Generic;

namespace Memento
{
    class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }

        public Estado Pega(int i)
        {
            return Estados[i];
        }
    }
}
 