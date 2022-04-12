using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cliente cliente = new Cliente();
            cliente.Nome = "joao";
            cliente.Endereco = "Rua das flores";
            cliente.DataNascimento = DateTime.Now;

            string xml = new GeradorXml().GeraXml(cliente);

            Console.WriteLine(xml);
        }
    }
}
