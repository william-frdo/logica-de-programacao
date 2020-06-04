/* B02
 * Faça um programa que receba três notas de um aluno, calcule e mostre a
 * média aritmética e a mensagem constante na tabela a seguir. Aos alunos
 * que ficaram para exame, calcule e mostre a nota que deverão tirar para
 * serem aprovados, considerando que a média exigida é 6,0.
 * 
 * MÉDIA aritmética     mensagem
 * 0,0      2,9         Reprovado
 * 3,0      6,9         Exame
 * 7,0      10,0        Aprovado
*/

using System;

class B02
{
    static void Main(string[] args)
    {
        double n1, n2, n3, med;

        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());

        med = (n1 + n2 + n3) / 3;

        if (med >= 0.0 && med < 3.0)
        {
            Console.WriteLine($"{med:F2} - Reprovado");
        }
        else if (med < 7.0)
        {
            // Calcula a nota mínima necessária para aprovação
            med = 12 - med;

            Console.WriteLine($"{med:F2} - Exame.");
            Console.WriteLine($"Nota necessária para aprovação: {med:F2}");
        }
        else if (med <= 10.0)
        {
            Console.WriteLine($"{med:F2} - Aprovado");
        }
    }
}