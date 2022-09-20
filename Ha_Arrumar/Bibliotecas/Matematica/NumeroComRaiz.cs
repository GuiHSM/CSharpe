using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class NumeroComRaiz
    {
        public int foraDaRaiz { get; set; }
        public int dentroDaRaiz { get; set; }
        public int indice { get; set; }
        public NumeroComRaiz(int dentroDaRaiz, int foraDaRaiz, int indice)
        {
            this.dentroDaRaiz = dentroDaRaiz;
            this.foraDaRaiz = foraDaRaiz;
            this.indice = indice;
        }
        public override string ToString()
        {
            return this.foraDaRaiz + "Raiz " + indice + "ª de " + this.dentroDaRaiz;
        }
        public bool Equals(NumeroComRaiz raiz)
        {
            bool resultado = false;
            if ((this.dentroDaRaiz == raiz.dentroDaRaiz) && (this.foraDaRaiz == raiz.foraDaRaiz) & (this.indice == raiz.indice))
                resultado = true;
            return resultado;
        }
    }
}
