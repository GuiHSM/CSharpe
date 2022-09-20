using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class Fracao
    {
        public int divisor { get; set; }
        public int dividendo { get; set; } 
        public Fracao(int dividendo, int divisor)
        {
            this.dividendo = dividendo;
            this.divisor = divisor;
        }
        public override string ToString()
        {
            return this.divisor + "/" + this.dividendo;
        }
        public bool Equals(Fracao fra)
        {
            bool resultado = false;
            if ((this.dividendo == fra.dividendo) && (this.divisor == fra.divisor))
                resultado = true;
            return resultado;
        }
    }
}
