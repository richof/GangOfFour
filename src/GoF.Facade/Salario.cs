// richoRichof fSalario.cs2722:46

using System;
namespace GoF.Facade
{

    public class Salario
    {

    public bool EhInteressante(Vaga vaga)
    {
        Console.WriteLine(" Validar salario para " + vaga.Nome);
        var rnd = new Random();
        var interessante = rnd.Next(0, 1);
        return Convert.ToBoolean(interessante);
    }

  }

}