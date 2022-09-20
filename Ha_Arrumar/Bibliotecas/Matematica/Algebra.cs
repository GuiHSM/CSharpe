using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class Algebra
    {
        public double SomaDeProgressaoAritmetica(double a1, double an, double n)
        {
            return (a1 + an) / 2 * n;
        }
        public double SomaDeProgressaoGeometricaFintita(double a1, int r, int n)
        {
            Aritmetica calculos = new Aritmetica();
            double rFinal = calculos.PotencializacaoIndiceInteiro(r, n);
            return (a1 * (1 - rFinal)) / (1 - r);
        }
        public double EquacaoQuadrada(double a, double b, double c, int umOuDois)
        {
            double resultado = 0, delta = 0;
            delta = b * b - 4 * a * c;
            if (umOuDois == 1)
                resultado = (-b + (Math.Sqrt(delta))) / 2;
            if (umOuDois == 2)
                resultado = (-b - (Math.Sqrt(delta))) / 2;
            return resultado;
        }
        public double SomaDeProgressaoGeometricaInfintita(double a1, double r)
        {
            return a1 / (1 - r);
        }
    }
}
