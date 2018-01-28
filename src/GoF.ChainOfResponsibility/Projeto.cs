// richoRichof fProjeto.cs2810:33
namespace GoF.ChainOfResponsibility
{

    public class Projeto
    {

        public Projeto(string nome, double orcamento)
        {
            Nome=nome;
            Orcamento=orcamento;
        }
        public string Nome{get; private set;}
        public double Orcamento{get; private set;}

    }

}