/* B01
 * A nota final de um estudante é calculada a partir de três notas atribuídas,
 * respectivamente, a um trabalho de laboratório, a uma avaliação semestral e
 * a um exame final. A média das três notas mencionadas obedece aos pesos a seguir:
 * 
 * Nota                         PESO
 * Trabalho de laboratório      2
 * Avaliação semestral          3
 * Exame final                  5
 * 
 * Faça um programa que receba as três notas, calcule e mostre a média ponderada
 * e o conceito que segue a tabela:
 * 
 * MÉDIA PONDERADA              CONCEITO
 * 8,0      10,0                A
 * 7,0      7,9                 B
 * 6,0      6,9                 C
 * 5,0      5,9                 D
 * 0,0      4,9                 E
 */

using System;

class B01
{
    static void Main(string[] args)
    {
        double lab, sem, final, media;

        lab = double.Parse(Console.ReadLine());
        sem = double.Parse(Console.ReadLine());
        final = double.Parse(Console.ReadLine());

        media = (lab * 2 + sem * 3 + final * 5) / (2 + 3 + 5);

        if (media >= 0.0 && media < 5.0)
        {
            Console.WriteLine($"Média: {media:F1} - Conceito: E");
        }

        if (media >= 5.0 && media < 6.0)
        {
            Console.WriteLine($"Média: {media:F1} - Conceito: D");
        }

        if (media >= 6.0 && media < 7.0)
        {
            Console.WriteLine($"Média: {media:F1} - Conceito: C");
        }

        if (media >= 7.0 && media < 8.0)
        {
            Console.WriteLine($"Média: {media:F1} - Conceito: B");
        }

        if (media >= 8.0 && media <= 10.0)
        {
            Console.WriteLine($"Média: {media:F1} - Conceito: A");
        }
    }
}