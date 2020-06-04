/* C04
   Foi feita uma estatística em cinco cidades brasileiras para coletar dados sobre acidentes
   de trânsito.
   Foram obtidos os seguintes dados:
   a) código da cidade;
   b) número de veículos de passeio;
   c) número de acidentes de trânsito com vítimas.
   Deseja-se saber:
   a) qual é o maior e qual é o menor índice de acidentes de trânsito e a que cidades pertencem;
   b) qual é a média de veículos nas cinco cidades juntas;
   c) qual é a média de acidentes de trânsito nas cidades com menos de 2.000 veículos de passeio.
*/

using System;

class C04
{
    static void Main(string[] args)
    {
        int codCidade, codCidadeMenor = 0, codCidadeMaior = 0, nVeiculos, nAcidentes;
        int indMaior = 0, indMenor = 0, somaVeiculos = 0, somaAcidentes = 0;
        int cidadeComMenosDe2000 = 0;
        double medVeiculos, medAcidentes;

        int c = 1;

        while (c <= 5)
        {
            Console.Write($"Código da {c}ª cidade: ");
            codCidade = int.Parse(Console.ReadLine());
            Console.Write($"Número de veículos da {c}ª cidade: ");
            nVeiculos = int.Parse(Console.ReadLine());
            Console.Write($"Número de acidentes da {c}ª cidade: ");
            nAcidentes = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                codCidadeMenor = codCidade;
                codCidadeMaior = codCidade;
                indMenor = nAcidentes;
                indMaior = nAcidentes;
            }

            if (indMenor > nAcidentes)
            {
                indMenor = nAcidentes;
                codCidadeMenor = codCidade;
            }

            if (indMaior < nAcidentes)
            {
                indMaior = nAcidentes;
                codCidadeMaior = codCidade;
            }

            if (nVeiculos < 2000)
            {
                cidadeComMenosDe2000++;
                somaAcidentes += nAcidentes;
            }

            somaVeiculos += nVeiculos;
            c++;
        }

        medVeiculos = (double)somaVeiculos / 5;
        medAcidentes = (double)somaAcidentes / cidadeComMenosDe2000;

        Console.WriteLine();
        Console.WriteLine($"Maior índice de acidentes: {indMaior}, código da cidade: {codCidadeMaior}");
        Console.WriteLine($"Menor índice de acidentes: {indMenor}, código da cidade: {codCidadeMenor}");
        Console.WriteLine($"Média de veículos: {medVeiculos}");
        Console.WriteLine($"Média de acidentes em cidade com menos de 2000 veículos: {medAcidentes}");
    }
}