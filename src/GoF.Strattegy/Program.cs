using System;

namespace GoF.Strattegy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora=new Calculadora();

            calculadora.AdicionarOperacao(new Soma(6,2));
            calculadora.AdicionarOperacao(new Subtracao(6, 2));
            calculadora.AdicionarOperacao(new Multiplicacao(6, 2));
            calculadora.AdicionarOperacao(new Divisao(6, 2));
            calculadora.ImprimirResultados();
            Console.ReadKey();
        }
    }
}
