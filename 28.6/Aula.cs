using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Aula
    {
        public int capienza {  get; set; }
        public string nome { get; set; }
        public List<string> elrisorse { get; set;}
        public void aggiungirisorse (string risorse)
        {
            elrisorse.Add(risorse);
        }
    }
}
