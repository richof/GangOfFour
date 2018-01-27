// richoRichof fEscritorioFactory.cs2718:13
namespace GoF.AbstractFactory
{

    public abstract class EscritorioFactory
    {

        public abstract Supervisor CriarSupervisor( string nome);

        public abstract Supervisionado CriarSupervisionado( string nome);


    }

}