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
        
        //elenco lezioni
       public void Stampalezioni()
        {
            foreach(Lezione lezione in this.lezioni)
            {
                Console.WriteLine(lezione.descrizione);
            }
        }

        public void Stampaelencoiscritti()
        {
            foreach(Studente studente in this.studenti)
            {
                Console.WriteLine("{0} {1}", studente.Nome, studente.Cognome);
            }
        }
        // media presenti ad un corso
        public float mediapresentialezione()
        {
            float totpresenti = 0;
            foreach(Lezione lezione in this.lezioni)
            {
                totpresenti = totpresenti + lezione.presenti.Count;
            }
            return totpresenti/this.lezioni.Count;
    }
}
