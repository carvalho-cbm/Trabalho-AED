using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ordenador
{
    // Método público para ordenar a lista de candidatos
    public static void QuickSort(List<Candidato> lista)
    {
        QuickSort(lista, 0, lista.Count - 1);
    }

    // Implementação recursiva do QuickSort
    private static void QuickSort(List<Candidato> lista, int esq, int dir)
    {
        int i = esq, j = dir;
        Candidato pivo = lista[(esq + dir) / 2];

        while (i <= j)
        {
            while (Comparar(lista[i], pivo) > 0) i++;
            while (Comparar(lista[j], pivo) < 0) j--;

            if (i <= j)
            {
                var temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
                i++;
                j--;
            }
        }

        if (esq < j) QuickSort(lista, esq, j);
        if (i < dir) QuickSort(lista, i, dir);
    }

    // Retorna >0 se a1 deve vir antes de a2 (ordem decrescente)
    private static int Comparar(Candidato a1, Candidato a2)
    {
        if (a1.NotaMedia != a2.NotaMedia)
            return -a1.NotaMedia.CompareTo(a2.NotaMedia); // decrescente
        else
            return -a1.NotaRedacao.CompareTo(a2.NotaRedacao); // decrescente
    }
}