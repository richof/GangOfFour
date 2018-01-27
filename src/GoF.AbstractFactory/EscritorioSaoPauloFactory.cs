// richoRichof fEscritorio.cs2718:19
namespace GoF.AbstractFactory
{

    public class EscritorioSaoPauloFactory:EscritorioFactory
    {

        public override Supervisor CriarSupervisor( string nome)
        {
            return new Diretor(nome);
        }

        public override Supervisionado CriarSupervisionado(string nome)
        {
            return new Secretaria(nome);
        }

    }

}