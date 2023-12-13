using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestione_di_corsi
{
    internal class Aula
    {
        public int Capienza { get; set; } 
        public string Nome { get; set; }
        public List<string> Risorse { get; set; }
    }
}
