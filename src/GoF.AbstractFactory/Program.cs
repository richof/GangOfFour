using System;

namespace GoF.AbstractFactory
{

    class Program
    {

        static void Main(string[] args)
        {
            EscritorioFactory saoPaulo=new EscritorioSaoPauloFactory();
            EscritorioFactory rioDeJaniero=new EscritorioRioDeJaneiroFactory();
            Console.WriteLine("São Paulo");
            Sucursal sucursal=new Sucursal(saoPaulo,"Richof", "Andreia");
            sucursal.DefinirHerarquia();
            Console.WriteLine("Rio de Janeiro");
            sucursal=new Sucursal(rioDeJaniero, "Daniela", "Fernanda");
            sucursal.DefinirHerarquia();
            Console.ReadKey();
        }

    }

}
