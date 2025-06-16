using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED.Models
{
    internal class Candidato
    {
        public string NomeCandidato { get; private set; }
        public double NotaMediaCandidato { get; private set; }
        public double NotaRedacao { get; private set; }
        public int[] NotasCandidato { get; private set; }
        public int PrimeiraOpcao { get; private set; }
        public int SegundaOpcao { get; private set; }
    }
}
