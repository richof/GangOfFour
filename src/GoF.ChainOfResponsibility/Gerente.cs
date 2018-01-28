// richoRichof fGerente.cs2810:46

using System;
namespace GoF.ChainOfResponsibility
{

    public class Gerente:Aprovador
    {
        public override void Aprovar(Projeto projeto)
        {
            if (projeto.Orcamento < 18000)
            {
                Console.WriteLine(this.GetType().Name + " aprovou o projeto " + projeto.Nome);
                Console.WriteLine("Iniciar projeto!!!");
                if (ProximoNaHierarquia != null)
                {
                    ProximoNaHierarquia.Aprovar(projeto);
                }
            }
            else
            {
                Console.WriteLine(this.GetType().Name + " não aprovou o projeto " + projeto.Nome);
                Console.WriteLine("O projeto não foi aprovado :(");
                if (ProximoNaHierarquia != null)
                {
                    ProximoNaHierarquia.Aprovar(projeto);
                }
            }
        }


    }

}