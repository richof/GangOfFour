// richoRichof fEmpresa.cs2722:37

using System;
namespace GoF.Facade
{

    public class Ambiente
    {

        public bool EhDescontraido(Vaga vaga)
        {
            Console.WriteLine(" Validar ambiente para  "+vaga.Nome);
            var rnd=new Random();
            var descontraido=rnd.Next(0, 1);
            return Convert.ToBoolean(descontraido);
        }

    }

}