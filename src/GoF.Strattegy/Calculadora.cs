// richoRichof fCalculadora.cs2809:22

using System;
using System.Collections.Generic;
namespace GoF.Strattegy
{

    public class Calculadora
    {

        private List<Operacao> _operacoes;

        public Calculadora()
        {
            _operacoes=new List<Operacao>();
        }
        public void AdicionarOperacao(Operacao operacao)
        {
            _operacoes.Add(operacao);
        }

        public void ImprimirResultados()
        {
            foreach(var op in _operacoes)
            {
                Console.WriteLine(" ");
                Console.Write(op.GetType().Name+ " =");
                Console.Write(op.Calcular());


            }
        }
    }

}