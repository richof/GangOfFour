using System;

namespace GoF.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidadorDeVagas validador=new ValidadorDeVagas();
            var vaga=new Vaga("Desenvolvedor .NET");
            bool ehAplicavel=validador.PossoAplicar(vaga);

            Console.WriteLine(" Eu "+(ehAplicavel ? " quero " : " não quero ")+"aplicar à vaga "+vaga.Nome);
            Console.ReadKey();
        }
    }
}
