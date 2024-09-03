using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.home
{
    public class Fatura
    {
        public decimal buscartotal(string cpf)
        {
            var totaldafatura = totaldobanco(cpf);

            return Convert.ToDecimal( totaldafatura);
        }

        private double totaldobanco(string cpf)
        {
            var totalencontrado = 100.50;
            return totalencontrado;
        }
    }
}
