using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parouimpar
{
    class par
    {
        private Double valor;

        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value);
            }
        }


        public string envia
        {
            get
            {
                if (valor%2 == 0) return "O numero "+ valor +" é Par";
                else return "O numero " + valor + " é Impar";
            }
        }
    }
}
