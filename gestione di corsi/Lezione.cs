using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_di_corsi
{
    internal class Lezione 
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public string OraDiInizio { get; set; }
        public int Durata { get; set; }
        public Docente Docente { get; set; }
        public Aula Aula { get; set; }
        public Corso Corso { get; set; }
        public List<Studente> StudentiPresenti { get; set; }


        public void SegnaAssenti(List<Studente> assenti)
        {
            StudentiPresenti = Corso.Studenti;

            foreach (Studente s in assenti) {
                StudentiPresenti.Remove(s);
            }
        }

        public void SchedaRiassuntiva()
        {
            Console.WriteLine("Descrizione: {0}\n Data: {1}\n OraDiInizio: {2}\n Durata: {3}\n Docente: {4}\n Aula: {5}\n Corso: {6}\n",
                this.Descrizione, this.Data, this.OraDiInizio, this.Durata, this.Docente, this.Aula, this.Corso); 
        }

        public void ElencoPresenti()
        {
            foreach (Studente st in StudentiPresenti)
            {
                Console.WriteLine("{0}\n", st);
            }
        }

    }
     
}
