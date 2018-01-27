// richoRichof fEmpresa.cs2718:40
namespace GoF.AbstractFactory
{

    public class Sucursal
    {

        private readonly Supervisor _supervisor;
        private readonly Supervisionado _supervisionado;

        public Sucursal(EscritorioFactory factory, string nomeSupervisor, string nomeSupervisionado)
        {
            _supervisor=factory.CriarSupervisor(nomeSupervisor);
            _supervisionado = factory.CriarSupervisionado(nomeSupervisionado);
                
        }

        public void DefinirHerarquia()
        {
            _supervisor.Supervisiona(_supervisionado);
        }

    }

}