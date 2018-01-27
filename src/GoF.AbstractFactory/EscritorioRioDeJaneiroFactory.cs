// richoRichof fEscritorioRioDeJaneiro.cs2719:25
namespace GoF.AbstractFactory
{

    public class EscritorioRioDeJaneiroFactory:EscritorioFactory
    {

        public override Supervisor CriarSupervisor(string nome)
        {
            return new Diretor(nome);
        }

        public override Supervisionado CriarSupervisionado(string nome)
        {
            return new Secretaria(nome);
        }

    }

}