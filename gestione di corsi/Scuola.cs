using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_di_corsi
{
    internal class Scuola
    {
        public List<Corso> Corsi { get; set; }
        public List<Aula> Aule { get; set; }
        public List<Docente> Docenti { get; set; }
        public void AggiungiCorso(Corso corso)
        {
            this.Corsi.Add(corso);
        }
        public List<Corso> ElencoCorsi()
        {
            return this.Corsi;
        }
        
    }

}
