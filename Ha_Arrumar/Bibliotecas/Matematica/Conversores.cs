using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class Conversores
    {
        public Fracao StringToFracao(string fracao)
        {
            string[] numeros = fracao.Split('/');
            Fracao haFracao = new Fracao(Convert.ToInt32(numeros[0]), Convert.ToInt32(numeros[1]));
            return haFracao;
        }
        public Fracao DoubleToFracao(double numero)
        {
            int numeroAlternativo = Convert.ToInt32(numero);
            int divisor = 1;
            while (numero - numeroAlternativo != 0)
            {
                divisor *= 10;
                numero *= 10;
                numeroAlternativo = Convert.ToInt32(numero);
            }
            return new Fracao(numeroAlternativo, divisor);
        }
    }
}
