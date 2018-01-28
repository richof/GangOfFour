// richoRichof fDiretor.cs2718:08

using System;
namespace GoF.AbstractFactory
{

    public class Diretor:Supervisor
    {

        public Diretor(string nome)
        {
            Nome = nome;
        }
        
        public override void Supervisiona(Supervisionado supervisionado)
        {
           
            Console.WriteLine(" O  "+this.GetType().Name+" "+ Nome+" supervisiona à "+supervisionado.GetType().Name+" " + supervisionado.Nome);

        }

    }

}