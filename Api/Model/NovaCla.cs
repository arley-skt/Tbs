
namespace Api.Model
{
    public class NovaCla
    {
        public string carregador { get; set; }
         public string fone { get; set; }
        public string celular { get; set; }
        public int filtrar { get; set; }
        public string deveselecionado { get; set; }
        public int anonasc { get; set; }

        public NovaCla() { }
        public NovaCla(string Carregador, string Fone, string Celular, int Filtrar , string Devesle, int Ano)
        {
            this.carregador = Carregador;
            this.fone = Fone;
            this.celular = Celular;
            this.anonasc = Ano;
            this.filtrar = Filtrar;
            this.deveselecionado = Devesle;
                
        }

        public int calcularidade(int ano)
        {
            var idade = 2025 - ano;

            return idade;
        }
       

    }
}
