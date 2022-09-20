using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication5
{
    class Iniciar
    {
        public static List<string> PuxarArquivos(string nome)
        {
            List<string> texto = new List<string>();
            using (Stream documento = File.Open(nome + ".txt", FileMode.Open))
            using (StreamReader leitor = new StreamReader(documento))
            {
                string batata = leitor.ReadLine();
                while (batata != null)
                {
                    texto.Add(batata);
                    batata = leitor.ReadLine();
                }
            }
            return texto;
        }
    }
}
