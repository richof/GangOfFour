// richoRichof fSoma.cs2809:14
namespace GoF.Strattegy
{

    public class Soma:Operacao
    {

       
        public Soma(int numero1, int numero2)
        {
            Numero1=numero1;
            Numero2=numero2;
        }

        public override double Calcular()
        {
            return Numero1+Numero2;
        }

    }

}