using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Matematica
{
    class Aritmetica
    {
        public double RegraDeTres(double valorOposto, double outroValor, double outroValor2)
        {
            double resultado = 0;
            resultado = outroValor * outroValor2 / valorOposto;
            return resultado;
        }
        public double PotencializacaoIndiceInteiro(int bases, int expoente)
        {
            double valorFinal = 1;
            for (int i = 1; i <= expoente; i++)
                valorFinal = valorFinal * bases;
            return valorFinal;
        }
        public Fracao[] PotencializacaoFinal(Fracao bases, Fracao expoente, bool positivoOuNegativo)
        {
            int dividendo = Convert.ToInt32(PotencializacaoIndiceInteiro(bases.dividendo,expoente.dividendo));
            int divisor = Convert.ToInt32(PotencializacaoIndiceInteiro(bases.divisor, expoente.dividendo));
            NumeroComRaiz emCima = this.Radiciacao(dividendo, expoente.divisor);
            NumeroComRaiz emBaixo = this.Radiciacao(divisor, expoente.dividendo);
            Fracao fracaoForaDaRaiz = new Fracao(emCima.foraDaRaiz, emBaixo.foraDaRaiz);
            Fracao fracaoDentroDaRaiz = new Fracao(emCima.dentroDaRaiz, emBaixo.dentroDaRaiz);
            if (positivoOuNegativo == true)
            {
                fracaoForaDaRaiz = new Fracao(emBaixo.foraDaRaiz, emCima.foraDaRaiz);
                fracaoDentroDaRaiz = new Fracao(emBaixo.dentroDaRaiz, emCima.dentroDaRaiz);
            }
            Fracao[] fracaoFinal = new Fracao[2];
            fracaoFinal[1] = this.Simplificacao(fracaoDentroDaRaiz);
            fracaoFinal[0]= this.Simplificacao(fracaoForaDaRaiz);
            return fracaoFinal;
        }
        public NumeroComRaiz Radiciacao(int radicando, int indice)
        {
            List<int> fatores = this.DecomposicaoEmFatoresPrimos(radicando);
            List<int> duplos = new List<int>();
            List<int> singular = new List<int>();
            bool ultimoEhDuplo = false;
            int contadorNovo=0;
            for (int i = 0; i < fatores.Count - (indice-1); i++)
            {
                if (fatores[i] == fatores[i + (indice-1)])
                {
                    duplos.Add(fatores[i]);
                    if (i == fatores.Count - indice)
                        ultimoEhDuplo = true;
                    i += indice-1;
                    if (fatores.Count - i < indice)
                        contadorNovo = i;
                }
                else
                {
                    singular.Add(fatores[i]);
                }
            }
            if (!(ultimoEhDuplo))
            {
                if (!(fatores.Count < (indice - 1)))
                {
                    if (contadorNovo == 0)
                    {
                        for (int i = fatores.Count - (indice - 1); i < fatores.Count; i++)
                            singular.Add(fatores[i]);
                    }
                    else
                    {
                        for (int i = contadorNovo; i < fatores.Count; i++)
                            singular.Add(fatores[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < fatores.Count; i++)
                        singular.Add(fatores[i]);
                }
            }
            int totalForaDaRaiz = 1, totalDentroDaRaiz = 1, contador = 0;
            foreach (int c in duplos)
            {
                totalForaDaRaiz = totalForaDaRaiz * duplos[contador];
                contador += 1;
            }
            contador = 0;
            foreach (int c in singular)
            {
                totalDentroDaRaiz = totalDentroDaRaiz * singular[contador];
                contador += 1;
            }
            return new NumeroComRaiz(totalDentroDaRaiz, totalForaDaRaiz, indice);

        }
        public bool EhPrimo(int numero)
        {
            bool resposta = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero%i == 0)
                    resposta = false;
            }
            return resposta;
        }
        public List<int> DecomposicaoEmFatoresPrimos(int numero)
        {
            List<int> fatores = new List<int>();
            for (int i = 2; i <= numero; i++)
            {
                if (this.EhPrimo(i))
                {
                    if (numero % i == 0)
                    {
                        fatores.Add(i);
                        numero = numero / i;
                        if (numero % i == 0)
                            i--;
                    }
                }
            }
            return fatores;
        }
        public Fracao Simplificacao(Fracao fracao)
        {
            int dividendo = fracao.dividendo;
            int divisor = fracao.divisor;
            List<int> fatoresDividendo = this.DecomposicaoEmFatoresPrimos(dividendo);
            List<int> fatoresDivisor = this.DecomposicaoEmFatoresPrimos(divisor);
            for (int x = 0; x < fatoresDividendo.Count; x++)
            {
                for (int y = 0; y < fatoresDivisor.Count; y++)
                {
                    if (fatoresDividendo[x] == fatoresDivisor[y])
                    {
                        fatoresDivisor.Remove(y);
                        int fatorComum = Convert.ToInt32(fatoresDividendo[x]);
                        dividendo /= fatorComum;
                        divisor /= fatorComum;
                        break;
                    }
                }
            }
            return new Fracao(dividendo,divisor);
        }
    }
}
