using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Lezione
    {
        public string descrizione { get; set; }
        public DateTime data { get; set; }
        public string orarioinizio { get; set; }
        public int durata { get; set; } 
        public Docente docente { get; set; }
        public Aula aulassegnata { get; set; }
        public List<Studente> presenti { get; set; }
        public void aggiungerepresenze(Studente studente)
        {
            presenti.Add(studente);
        }
       public List<Studente>assenti { get; set; }
       public void segnareassenti(Studente studente)
        {
            assenti.Add(studente);
        }
    }
}
