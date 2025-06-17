using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe responsável por processar e alocar candidatos nos cursos
public class ProcessadorDeCandidatos
{
    public static void ProcessarCandidatos(List<Candidato> candidatos, Dictionary<int, Curso> cursos)
    {
        foreach (var c in candidatos)
        {
            c.CalcularNotaMedia();

            // Verifica se há vaga na 1ª opção
            var curso1 = cursos[c.CodCurso1];
            var curso2 = cursos[c.CodCurso2];

            if (curso1.TemVaga())
            {
                curso1.AdicionarSelecionado(c);
                // Libera a 2ª opção, não entra em fila de espera
            }
            else if (curso2.TemVaga())
            {
                curso2.AdicionarSelecionado(c);
                curso1.AdicionarFilaEspera(c); // entra na fila da 1ª opção
            }
            else
            {
                // Não passou em nenhuma, entra na fila das duas opções
                curso1.AdicionarFilaEspera(c);
                curso2.AdicionarFilaEspera(c);
            }
        }
    }
}

