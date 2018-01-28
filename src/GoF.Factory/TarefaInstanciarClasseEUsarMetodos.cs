// richoRichof fInstanciarClasseEUsarMetodos.cs2721:23
namespace GoF.Factory
{

    public class TarefaInstanciarClasseEUsarMetodos : Tarefa
    {

        public override void AdicionarInstrucoes()
        {
            Instrucoes.Add(new InstrucaoDeclararVariavel());
            Instrucoes.Add(new InstrucaoInstanciarClasse());
            Instrucoes.Add(new InstrucaoInvocarMetodo());
        }

    }

}