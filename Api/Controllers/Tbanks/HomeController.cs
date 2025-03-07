using Api.Model;
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

            var usandometodonome = getnomex();
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
                
                msg = "usuario invalidoo";
            }

           // var Tok = new AccountTokenViewModel { Token = Guid.NewGuid(), TokenRefresh = Guid.NewGuid() };

            return Ok(msg);
        }

        [HttpPost]
        [Route("buscarnselecionado")]
        public async Task<ActionResult<string>> buscarselecionado([FromBody] string carregador, string fone, string celular, int filtrar, string deveselecionado, int anonasc)
        {
            var msg = "";
            var brasil = new Manipulador();
            var novaloja = brasil.criadordeloja(celular, fone, carregador);

            //consumindo meu método criado, chamar atraves do nomedometodocriado e com o parametro se houver
            //var devselecionado = nomedodev(deveselecionado);

            var databuscada = retonaridade(anonasc);

            var retornodiltragem = filtrarpedidos(filtrar);

            var minhavariavel = kamila(deveselecionado);

            msg = brasil.retornarcelularecarregador(celular, carregador);

            var mensagem = "";

            if (minhavariavel == null)
            {
                mensagem = "Usuario não encontrado na lista";
            }
            else
            {
                mensagem = "este é o usuario filtrado " + minhavariavel;
            }

            return Ok(mensagem);

        }

        [HttpPost]
        [Route("buscarlojas")]
        public async Task<ActionResult<string>> buscarloja ([FromBody] NovaCla nvClasse)
        {
            var msg = "";
            var brasil = new Manipulador();
            var novaloja = brasil.criadordeloja(nvClasse.celular, nvClasse.fone, nvClasse.carregador);

            //consumindo meu método criado, chamar atraves do nomedometodocriado e com o parametro se houver
            //var devselecionado = nomedodev(deveselecionado);



            nvClasse.carregador = "Carregadormotorola";


            //vai ter que buscar uma instancia da nova classe no banco

            //var nvclasseDb = ///meu codigo buscando la na camada de aplication e camada de infra.

            var minhanovainstanciadoobjeto = new NovaCla("xiaomi","daredm","samg",50,"nathy",2000);

            
         


            var databuscada = retonaridade(nvClasse.anonasc);

            var retornodiltragem = filtrarpedidos(nvClasse.filtrar);
            var minhavariavel = kamila(nvClasse.deveselecionado);
            msg = brasil.retornarcelularecarregador(nvClasse.celular, nvClasse.carregador);

            var mensagem = "";

            if (minhavariavel==null)
            {
                mensagem = "Usuario não encontrado na lista";
            }
            else
            {
                mensagem = "este é o usuario filtrado " + minhavariavel;
            }
            
            return Ok(mensagem);

        }

        private int filtrarpedidos(int fatorbusca)
        {
            var minhavariavel = 0;

            

            while(fatorbusca > 10 && fatorbusca < 100)
            {
                if(fatorbusca == 50)
                {
                    fatorbusca = 10;
                }
                else if (fatorbusca == 20)
                {
                    fatorbusca = 5;
                }
                else
                {
                    fatorbusca = 10;
                }
            }

            if (fatorbusca==0)
            {
                
                return 0;
            }
            else
            {
                var itensfiltrado = 10;
                //minha logica de negocio
                //passar para camada de aplication e a alication chamar o banco
                return itensfiltrado;
            }
        }

        //1 - criar um metodo que retorne seu nome
        //2 - criar uma variavel e atribuir os valores consumindo o metodo getdevs 
        //3 - incluir mais dois devs na lista
        //4 - filtrar o dev selecionado
        //5 - retornar nome nao encontrado caso nao exista

        public string kamila(string kamila) 
        {
            var novonome = "joao";
            var novonome2 = "bia";
            var lista1 = getdevs();
            lista1.Add(novonome);
            lista1.Add(novonome2);

            var posicaoselecionada = lista1.Where(x => x == kamila).FirstOrDefault();

            return posicaoselecionada;
        }
        public List<string> getdevs()
        {
            var listadevs = new List<string>();

            listadevs.Add("arley");
            listadevs.Add("kamis");
            listadevs.Add("nathy");

            return listadevs;
        }

        //criando meu metodo com parametro
        public int retonaridade(int datanasc)
        {
            var idade = 2025-datanasc;
            return idade;

        }

        private string getnomex()
        {
            var nome = "X";

            return nome;
        }


        //criando um novo metodo no caso o metodo nomedodev com o parametro do tipo string devselecionado
        private string nomedodev( string devselecionado)
        {
            var dev1 = "theodore";
            string dev2 = "nathy";
            var dev3 = "kamis";

            //criando uma lista no caso instancia da lista
            var listadevs = new List<string>();
            //adicionando valor a lista atraves da função .Add
            listadevs.Add(dev1);

            var existente = listadevs.Count();
            //filtrando um valor da lista
            var posicaoselecionada = listadevs.Where(x => x == dev1).FirstOrDefault();

            var temounao = listadevs.Contains(dev1);
                        
            
            if (!temounao)
            {
                listadevs.Add(dev1);
            }

             temounao = listadevs.Contains(dev2);


            if (!temounao)
            {
                listadevs.Add(dev2);
            }

             temounao = listadevs.Contains(dev3);


            if (!temounao)
            {
                listadevs.Add(dev3);
            }
          //para pos 0      0<tamanhodalista    incremento i=0
            for (int i = 0; i<listadevs.Count(); i++)
            {
                var devencontradonalista = listadevs[i];

                if (devencontradonalista!=devselecionado)
                {
                    listadevs.Add(devselecionado);
                }
            }

            

            for (int i = 0; i < listadevs.Count(); i++)
            {
                //selecionando o dev da lista
                var existe = listadevs.Where(x=>x==devselecionado).FirstOrDefault();
                // alterar para caixa alta maiusculo
                var existecx = existe.ToUpper();
                var devselecionadocx = devselecionado.ToUpper();
                //var temounaofor = listadevs.Contains(devselecionado);

                //if (existecx != devselecionadocx)
                //{
                //    listadevs.Add(devselecionado);

                //}
                //else
                //{
                //    break;
                //}
                
            }
           

            return "teste";


        }
        //private List<int> manipularlista()
        //{
        //    var num1 = 1;
        //    var num1 = 2;
        //    var num1 = 3;
        //    var num1 = 4;
        //    var num1 = 5;

        //}
    }
}
