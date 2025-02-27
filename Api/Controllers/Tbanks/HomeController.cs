using Api.ViewModel;
using Data.home;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Tbanks
{
    public class HomeController : Controller
    {
        [HttpPost]
        [Route("buscarpessoacpf")]
        public async Task<ActionResult<string>> buscarpessoacpf([FromBody] string cpf)
        {
            var pessoaencontrada = new usuario();
            var fatura = new Fatura();

            if (!ModelState.IsValid) 
                return BadRequest();
            var msg = "";
            var validacao = pessoaencontrada.validausurrio(cpf);


            var instanciaclientepessoafisica = new clientepessoafisica();

            var lista= instanciaclientepessoafisica.buscarpessoafisicalistadotodos();

            var posica5 = lista[4];

            var posicaopornome = lista.Where(x=>x.nome=="joao").FirstOrDefault();

            if (validacao)
            {
                var clienteenctradonobanco = pessoaencontrada.bucarnobancodadosusuario(cpf);
                var valorfaturado = fatura.buscartotal(clienteenctradonobanco.cpf.ToString());

                if (msg == "")
                {
                    msg = "Senhor(a)" +clienteenctradonobanco.nome+ " total da sua fatura é: "+valorfaturado;
                }
                else
                {
                    msg = "invalido1";
                }
            }
            else
            {
                 msg = "usuario invalidooo";
            }

           // var Tok = new AccountTokenViewModel { Token = Guid.NewGuid(), TokenRefresh = Guid.NewGuid() };

            return Ok(msg);
        }

        [HttpPost]
        [Route("buscarloja")]
        public async Task<ActionResult<string>> buscarloja ([FromBody] string carregador, string fone, string celular)
        {
            var msg = "";
            var brasil = new Manipulador();
            var novaloja = brasil.criadordeloja(celular, fone, carregador);


            msg = brasil.retornarcelularecarregador(celular,carregador);

            return Ok(msg);

        }
    }
}
