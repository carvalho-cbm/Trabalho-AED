using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_AED.Models
{
    internal class FilaFlexivel
    {
        private Celula primeiro, ultimo;
        public FilaFlexivel()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void Inserir(Candidato x)
        {
            ultimo.Prox = new Celula(x);
            ultimo = ultimo.Prox;
        }

        public string Remover()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            Celula tmp = primeiro;
            primeiro = primeiro.Prox;
            Candidato elemento = primeiro.Elemento;
            tmp.Prox = null;
            tmp = null;
            return elemento.NomeCandidato;
        }

        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.WriteLine(i.Elemento);
            }
        }
    }
}
