// richoRichof fTarefa.cs2721:16

using System.Collections.Generic;
namespace GoF.Factory
{

    public abstract class Tarefa
    {

       // private List<Instrucao> _instrucoes=new List<Instrucao>();
        protected Tarefa()
        {
            Instrucoes=new List<Instrucao>();
            AdicionarInstrucoes();
        }
        
        public List<Instrucao> Instrucoes { get; }
        public abstract void AdicionarInstrucoes();


    }

}