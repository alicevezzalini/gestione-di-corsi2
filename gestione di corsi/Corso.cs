using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_di_corsi
{
    internal class Corso
    {
        public string Nome { get; set; }
        public int Edizione { get; set; }
        public List<Lezione> Lezioni { get; set; } 
        public List<Studente> Studenti { get; set; }


        public Corso(string nome, int edizione) {
            this.Nome = nome;
            this.Edizione = edizione;
            this.Lezioni = new List<Lezione>();
            this.Studenti = new List<Studente>();
        }

        public void AggiungiLezione(Lezione lezione)
        {
            this.Lezioni.Add(lezione);
        }

        public void AggiungiStudente(Studente studente)
        {
            this.Studenti.Add(studente);
        }

        public List<Lezione> ElencoLezioni()
        {
            return this.Lezioni;
        }
        public double MediaPresentiCorso()
        {
            int somma = 0;
            foreach (Lezione le in this.Lezioni)
            {
               somma += le.StudentiPresenti.Count();
            }

            return somma / this.Lezioni.Count();
        }

    }
}
