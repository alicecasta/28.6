using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Corso
    {
        public string nome { get; set; }
        public int edizione { get; set; }
        public List<Lezione>lezioni {  get; set; } 
        public List<Studente>studenti { get; set; } 
        
        public void aggiungilezioni(Lezione lezione)
        {
            lezioni.Add(lezione);
        }
        public void aggiungistudenti(Studente studente, Lezione lezione)
        {
            studenti.Add(studente);
        }
        
    }
}
