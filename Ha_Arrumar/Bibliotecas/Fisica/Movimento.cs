using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matematica;

namespace Fisica
{
    class Movimento
    {
        public double SoVeTao_EspacoFinal(double velocidade, double tempo, double aceleracao, double espacoInicial)
        {
            return espacoInicial + (velocidade * tempo) + (aceleracao / 2 * tempo * tempo);
        }
        public double SoVeTao_EspacoInicial(double velocidade, double tempo, double aceleracao, double espacoFinal)
        {
            return espacoFinal - velocidade * tempo - aceleracao / 2 * tempo * tempo;
        }
        public double SoVeTao_Velocidade(double espacoInicial, double tempo, double aceleracao, double espacoFinal)
        {
            return (espacoFinal - espacoInicial - (aceleracao / 2 * tempo * tempo)) / tempo;
        }
        public double SoVeTao_Tempo(double velocidade, double espacoFinal, double aceleracao, double espacoInicial, int umOuDois)
        {
            Algebra calculos = new Algebra();
            return calculos.EquacaoQuadrada(aceleracao, velocidade, espacoInicial - espacoFinal, umOuDois);
        }
        public double SoVeTao_aceleracao(double velocidade, double tempo, double espacoFinal, double espacoInicial)
        {
            return (espacoFinal - espacoInicial - (velocidade * tempo)) / (2 * tempo * tempo);
        }
        public double Torricheli_VelocidadeFinal(double velocidadeInicial, double aceleracao, double deltaEspaco)
        {
            return Math.Sqrt(velocidadeInicial * velocidadeInicial + 2 * aceleracao * deltaEspaco);
        }
        public double Torricheli_Aceleracao(double velocidadeInicial, double velocidadeFinal, double deltaEspaco)
        {
            return velocidadeFinal * velocidadeFinal - velocidadeInicial * velocidadeInicial / (2 * deltaEspaco);
        }
        public double Torricheli_EspacoInicial(double velocidadeInicial, double aceleracao, double velocidadeFinal, double espacoFinal)
        {
            return espacoFinal - ((velocidadeFinal * velocidadeFinal - velocidadeInicial * velocidadeInicial) / 2 * aceleracao);
        }
        public double Torricheli_EspacoFinal(double velocidadeInicial, double aceleracao, double velocidadeFinal, double espacoFinal)
        {
            return espacoFinal + ((velocidadeFinal * velocidadeFinal - velocidadeInicial * velocidadeInicial) / 2 * aceleracao);
        }
    }
}
