using System;

namespace GoF.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarefa[] tarefas=new Tarefa[2];
            tarefas[0]=new TarefaCriarUmaClasse();
            tarefas[1]=new TarefaInstanciarClasseEUsarMetodos();
            int numeroInstrucao=0;
            foreach(var tarefa in tarefas)
            {
                Console.WriteLine("   ");
                Console.WriteLine("Nome: "+tarefa.GetType().Name);
                foreach(var instrucao in tarefa.Instrucoes)
                {
                    numeroInstrucao++;
                    Console.WriteLine(numeroInstrucao+" : " + instrucao.GetType().Name);
                }

                numeroInstrucao=0;
            }
            Console.ReadKey();
        }
    }
}
