using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parouimpar
{
    class par
    {
        private int valor;

        public string recebe
        {
            set
            {
                valor = Convert.ToInt32(value);
            }
        }


        public string envia
        {
            get
            {
                valor = Convert.ToInt32(value);
            }
        }
    }
}
