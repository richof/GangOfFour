// richoRichof fAprovador.cs2810:21
namespace GoF.ChainOfResponsibility
{

    public abstract class Aprovador
    {

        protected Aprovador ProximoNaHierarquia;

        public abstract void Aprovar(Projeto projeto);

        public void DefinirProximoAprovador(Aprovador proximoNaHierarquia)
        {
            ProximoNaHierarquia = proximoNaHierarquia;
        }


    }

}