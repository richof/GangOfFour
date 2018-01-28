// richoRichof fOperação.cs2809:10
namespace GoF.Strattegy
{

    public abstract class Operacao
    {
        protected int Numero1 { get; set; }
        protected int Numero2 { get; set; }
        public abstract double Calcular();



    }

}