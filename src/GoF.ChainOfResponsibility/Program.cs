using System;

namespace GoF.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Aprovador davidGilmour=new Gerente();
            Aprovador steveVai=new Diretor();
            Aprovador carlosSantana=new GerenteDeProjetos();

            carlosSantana.DefinirProximoAprovador(steveVai);
            steveVai.DefinirProximoAprovador(davidGilmour);

            var projeto=new Projeto("Implementação dos padrões do GoF", 19000);

            carlosSantana.Aprovar(projeto);
            
                
            

            Console.ReadKey();
        }
    }
}
