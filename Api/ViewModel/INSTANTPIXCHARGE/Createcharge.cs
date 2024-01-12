namespace Api.ViewModel.INSTANTPIXCHARGE
{
    public class Createcharge
    {
        public string txid {  get; set; }
        // BODY PARAMS
        public string chave { get; set; }
        public string solicitacaoPagador { get; set; }
        public Array infoAdicionais { get; set; }
        public string calendario { get; set; }
        public object valor { get; set; }

    }
}
