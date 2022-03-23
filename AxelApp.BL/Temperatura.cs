using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxelApp.BL
{
    public class Temperatura
    {
        public int Valor { get; set; }

        public double GetEquivalenteFahrenheit()
        {
            return Valor * 1.8 + 32;
        }

        public double GetEquivalenteReaumur()
        {
            return Valor * 0.8;
        }

    }
}
