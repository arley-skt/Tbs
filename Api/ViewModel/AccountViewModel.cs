namespace Api.ViewModel
{
    public class AccountViewModel
    {
        public Guid id { get; set; }
        public Guid FornecedorId { get; set; }
        public string nome { get; set; }       
        public PixOutViewModel? fornecedor { get; set; }

    }

    public class UserViewModel
    {
        public string User { get; set; }
        public string Senha { get; set; }


    }
    public class AccountTokenViewModel
    {
        public Guid Token { get; set; }
        public Guid TokenRefresh { get; set; }
     

    }
}
