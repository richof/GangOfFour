// richoRichof fTarefa.cs2721:16

using System.Collections.Generic;
namespace GoF.Factory
{

    public abstract class Tarefa
    {

        private List<Instrucao> _instrucoes=new List<Instrucao>();
        protected Tarefa()
        {
            CriarTarefas();
        }
        public List<Instrucao> Instrucoes { get
        {
            return _instrucoes;
        } }

        public abstract void CriarTarefas();


    }

}