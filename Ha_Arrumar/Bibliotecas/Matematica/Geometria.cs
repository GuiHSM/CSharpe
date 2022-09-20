using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class Geometria
    {
        public double TeoremaDePitagoras(double primeiroCateto, double segundoCateto)
        {
            double resultado = 0;
            resultado = Math.Sqrt(primeiroCateto * primeiroCateto + segundoCateto * segundoCateto);
            return resultado;
        }
        public double AreaPoligonoRegular(int lado, double tamanhoDoLado)
        {
            double perimetro = 0, apotemo = 0, angulo = 0;
            perimetro = tamanhoDoLado * lado;
            angulo = 360 / (lado * 2);
            apotemo = (lado / 2) / Math.Tan(angulo);
            return (perimetro * apotemo) / 2;
        }
        public double AreaPoligonoIrregular(List<double> todosOsX, List<double> todosOsY)
        {
            double resultado1 = 0, resultado2 = 0, resultadoFinal = 0;
            int contador = -1;
            foreach (double c in todosOsX)
            {
                if (contador + 1 == todosOsX.Count)
                {
                    resultado1 += todosOsX[0] * todosOsY[contador];
                    resultado2 += todosOsX[contador] * todosOsY[0];
                }
                else
                {
                    resultado1 += todosOsX[contador] * todosOsY[contador + 1];
                    resultado2 += todosOsX[contador + 1] * todosOsY[contador];
                }
                contador += 1;
            }
            double maior = Math.Max(resultado1, resultado2);
            if (maior == resultado2)
            {
                resultadoFinal = resultado2 - resultado1;
            }
            else if (maior == resultado1)
            {
                resultadoFinal = resultado1 - resultado2;
            }
            return resultadoFinal / 2;
        }
    }
}
