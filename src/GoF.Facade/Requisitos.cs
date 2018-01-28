// richoRichof fRequisitos.cs2722:48

using System;
namespace GoF.Facade
{

    public class Requisitos
    {

    public bool CumproOsRequisitos(Vaga vaga)
    {
        Console.WriteLine(" Validar requisitos para " + vaga.Nome);
        var rnd = new Random();
        var cumpro = rnd.Next(0, 1);
        return Convert.ToBoolean(cumpro);
    }

  }

}