// richoRichof fMultiplicacao.cs2809:18
namespace GoF.Strattegy
{

    public class Multiplicacao:Operacao
    {

        public Multiplicacao(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public override double Calcular()
        {
            return Numero1 * Numero2;
        }

    }

}