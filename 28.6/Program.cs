using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //aggiungere un corso
            Scuola scuola = new Scuola();   
            Corso corsoinformatica = new Corso();
            corsoinformatica.nome = "info";
            corsoinformatica.edizione = 2020;
            scuola.Corsi.Add(corsoinformatica);

            //aggiungere lezioni ad un corso
            Lezione l1= new Lezione();
            l1.data=new DateTime(2020, 3, 3, 10, 00, 00);
            l1.durata = 50;
            l1.docente = scuola.Docenti[5];//liste partono da zero
            l1.descrizione = "esercizio";
            corsoinformatica.lezioni.Add(l1);// aggiungiamo alle lezioni di corsoinformatica l1

            //aggiungere studenti ad un corso
            Studente stualice= new Studente();
            stualice.Nome = "Alice";
            stualice.Cognome = "Castaldi";
            corsoinformatica.studenti.Add(stualice);

            //segnare assenti
            l1.presenti.AddRange(corsoinformatica.studenti);//mi mette presenti tutti gli studenti del corso di info
            l1.presenti.RemoveAt(5);// sesto studente assente

            //elenco corsi
            scuola.Stampacorsi();

            //elenco lezioni
           corsoinformatica.Stampalezioni();
            corsoinformatica.Stampaelencoiscritti();
            corsoinformatica.mediapresentialezione();

        }
    }
}
