using System.Collections.Generic;

namespace Command
{
    internal class FilaDeTrabalho
    {
        private IList<ICommand> Comandos = new List<ICommand>();

        public void Adiciona(ICommand command)
        {
            this.Comandos.Add(command);
        }

        public void Processa()
        {
            foreach (ICommand command in Comandos)
            {
                command.Execute();
            }
        }
    }
}
