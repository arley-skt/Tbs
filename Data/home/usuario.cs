using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.home
{
    public class usuario
    {
        public bool validausurrio(string cpf)
        {
            if (cpf == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public clientebanco bucarnobancodadosusuario(string cpf)
        {
            var buscadorusuariofisica = new clientepessoafisica();

            var pessoaencontrada = buscadorusuariofisica.buscarpessoafisica(cpf);

            return pessoaencontrada;

        }

        
    }
}
