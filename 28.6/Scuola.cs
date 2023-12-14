using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Scuola
    {
        public List<Corso> Corsi  { get; set; }
        public List<Docente> Docenti { get; set; }
        //elemco corsi
        public void Stampacorsi()
        {
            foreach (Corso corsi in this.Corsi)
            {
                Console.WriteLine(Corso.nome);
            }
        }
    }
}
