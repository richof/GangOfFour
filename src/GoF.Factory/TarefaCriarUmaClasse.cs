// richoRichof fTarefaCriarUmaClasse.cs2721:32
namespace GoF.Factory
{

    public class TarefaCriarUmaClasse:Tarefa
    {

        public override void CriarTarefas()
        {
            Instrucoes.Add(new InstrucaoNomearClasse());
            Instrucoes.Add(new InstrucaoDeclararPropriedades());
            Instrucoes.Add(new InstrucaoDeclararConstrutor());
            Instrucoes.Add(new InstrucaoDeclararMetodos());
            
        }

    }

}