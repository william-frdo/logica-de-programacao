/* C09
   Faça um programa que receba duas notas de seis alunos. Calcule e mostre:
   a média aritmética das duas notas de cada aluno; e
   a mensagem que está na tabela a seguir:

   MÉDIA ARITMÉTICA | MENSAGEM
   Até 3            | Reprovado
   Entre 3 e 7      | Exame
   De 7 para cima   | Aprovado

   o total de alunos aprovados;
   o total de alunos de exame;
   o total de alunos reprovados;
   a média da classe
*/

using System;

class C09
{
    static void Main(string[] args)
    {
        int totAprovados = 0, totReprovados = 0, totExame = 0;
        double medClasse = 0;

        for (int i = 1; i <= 6; i++)
        {
            string mensagem = "";

            Console.Write($"Notas do {i}º aluno: ");
            string[] notas = Console.ReadLine().Split(" ");
            double n1 = double.Parse(notas[0]);
            double n2 = double.Parse(notas[1]);
            double medAluno = (n1 + n2) / 2;

            medClasse += medAluno;

            if (medAluno <= 3)
            {
                mensagem = "Reprovado";
                totReprovados++;
            }
            else if (medAluno <= 7)
            {
                mensagem = "Exame";
                totExame++;
            }
            else
            {
                mensagem = "Aprovado";
                totAprovados++;
            }

            Console.WriteLine($"Média do {i}º aluno: {medAluno:F2} - {mensagem}");
            Console.WriteLine();
        }

        medClasse /= 6;

        Console.WriteLine($"Total aprovados: {totAprovados}");
        Console.WriteLine($"Total exame: {totExame}");
        Console.WriteLine($"Total reprovados: {totReprovados}");
        Console.WriteLine($"Media classe: {medClasse:F2}");
    }
}