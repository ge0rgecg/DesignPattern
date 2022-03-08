using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expressões matematicas");
            var esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            var direita = new Subtracao(new Numero(20), new Numero(10));
            var resultado = new Divisao(new Numero(1000), new Multiplicacao(new Numero(2), new Soma(esquerda, direita)));

            Console.WriteLine(resultado.Avalia());

        }
    }
}
