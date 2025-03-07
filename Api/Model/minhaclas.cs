namespace Api.Model
{
    public class minhaclas
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        public int num4 { get; set; }

        public minhaclas() { }
        public minhaclas(int Num1, int Num2, int Num3, int Num4)
        {
            this.num1 = Num1;
            this.num2 = Num2;
            this.num3 = Num3;
            this.num4 = Num4;


        }
        public int calcularnum(int numero1, int numero2, int numero3, int numero4)
        {
            var soma = numero1 + numero2 + numero3 + numero4;
            var divisao = soma / 4;



            return divisao; 

        }
    }
}
