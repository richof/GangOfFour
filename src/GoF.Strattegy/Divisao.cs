// richoRichof fDivisao.cs2809:16
namespace GoF.Strattegy
{

    public class Divisao:Operacao
    {
        public Divisao(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public override double Calcular()
        {
            return Numero1 / Numero2;
        }

    }

}