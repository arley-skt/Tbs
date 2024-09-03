using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.home
{
    public class clientepessoafisica
    {

        public clientebanco buscarpessoafisica(string cpf)
        {
            if (cpf == "1234")
            {
                var clienteencontrado = new clientebanco("nathalia",3434);
              
                return clienteencontrado;
            }
            else if(cpf=="123")
            {
                var clienteencontrado = new clientebanco("kamila",3435);
               

                return clienteencontrado;
            }
            else
            {
               return new clientebanco("",0);
            }
            
        }

        public List<clientebanco> buscarpessoafisicalistadotodos()
        {
            var listarecuperada = new List<clientebanco>();
            
                var clienteencontrado1 = new clientebanco("maria", 6767);
               
                
           
            
                var clienteencontrado2 = new clientebanco("kamoça",56565);
               

            var clienteencontrado3 = new clientebanco("nath",45454);
           

            var clienteencontrado4 = new clientebanco("joao",3456);
            //clienteencontrado2.nome = "nathalia";
            //clienteencontrado2.cpf = 1234;

            var clienteencontrado5 = new clientebanco("arley",699);

            listarecuperada.Add(clienteencontrado1);
            listarecuperada.Add(clienteencontrado2);
            listarecuperada.Add(clienteencontrado3);
            listarecuperada.Add(clienteencontrado4);
            listarecuperada.Add(clienteencontrado5);


            return listarecuperada;


        }
    }
}
