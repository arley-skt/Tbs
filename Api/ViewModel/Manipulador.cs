namespace Api.ViewModel
{
    public class Manipulador
    {
        public Loja criadordeloja(string celular, string fone, string carregador) 
        {
          var novaloja = new Loja();
            novaloja.celular = celular;
            novaloja.fone = fone;
            novaloja.carregador = carregador;
            return novaloja;

        
        }
        public string retornarcelularecarregador(string celular, string carregador)
        {
            var nomejunto = celular + carregador;
            return nomejunto;
        }

    }
}
