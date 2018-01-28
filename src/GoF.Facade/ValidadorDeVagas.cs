// richoRichof fValidadorDeVagas.cs2722:50

using System;
namespace GoF.Facade
{

    public class ValidadorDeVagas
    {

        private Ambiente _ambiente= new Ambiente();
        private Salario _salario=new Salario();
        private Requisitos _requisitos=new Requisitos();

        public bool PossoAplicar(Vaga vaga)
        {
            Console.WriteLine(vaga.Nome);
            bool aplicavel = false;
            aplicavel=_ambiente.EhDescontraido(vaga);
            aplicavel=_salario.EhInteressante(vaga);
            aplicavel=_requisitos.CumproOsRequisitos(vaga);
            return aplicavel;
        }


    }

}