using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.home
{
    public class clientebanco
    {
        public string nome {  get; set; }
        public int cpf { get; set; }

        public clientebanco(string Nome, int Cpf) 
        { 
        this.nome= Nome;
            this.cpf= Cpf;
        }

         
    }
}
