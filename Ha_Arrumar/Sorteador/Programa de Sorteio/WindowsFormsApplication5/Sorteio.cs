using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    class Sorteio
    {
        public static string Sortear(List<string> nomes)
        {
            Random aleatorio = new Random();
            int escolhido = aleatorio.Next(0,nomes.Count);
            return nomes[escolhido];
        }
    }
}
