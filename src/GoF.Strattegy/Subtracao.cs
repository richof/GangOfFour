// richoRichof fSubtracao.cs2809:15
namespace GoF.Strattegy
{

    public class Subtracao:Operacao
    {

        public Subtracao(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public override double Calcular()
        {
            return Numero1 - Numero2;
        }

    }

}