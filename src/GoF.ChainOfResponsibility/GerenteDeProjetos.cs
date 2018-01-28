// richoRichof fGerenteDeProjetos.cs2810:38

using System;
namespace GoF.ChainOfResponsibility
{

    public class GerenteDeProjetos:Aprovador
    {

        public override void Aprovar(Projeto projeto)
        {
            if(projeto.Orcamento<8000)
            {
                Console.WriteLine(this.GetType().Name+" aprovou o projeto "+projeto.Nome);
                if (ProximoNaHierarquia != null)
                {
                    ProximoNaHierarquia.Aprovar(projeto);
                }
            }
            else
            {
                Console.WriteLine(this.GetType().Name + " não aprovou o projeto " + projeto.Nome);
                if(ProximoNaHierarquia!=null)
                {
                    ProximoNaHierarquia.Aprovar(projeto);
                }
            }
        }

    }

}