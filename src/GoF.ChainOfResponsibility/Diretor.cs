// richoRichof fDiretor.cs2810:44

using System;
namespace GoF.ChainOfResponsibility
{

    public class Diretor:Aprovador
    {
        public override void Aprovar(Projeto projeto)
        {
            if (projeto.Orcamento < 12000)
            {
                Console.WriteLine(this.GetType().Name + " aprovou o projeto " + projeto.Nome);
               
                if (ProximoNaHierarquia != null)
                {
                    ProximoNaHierarquia.Aprovar(projeto);
                }
            }
            else
            {
                Console.WriteLine(this.GetType().Name + " não aprovou o projeto " + projeto.Nome);
                if (ProximoNaHierarquia != null)
                {
                    ProximoNaHierarquia.Aprovar(projeto);
                }
            }
        }


    }

}