/* B14
 * Faça um programa que receba o salário inicial de um funcionário, calcule e mostre o novo salário,
 * acrescido de bonificação e de auxílio escola.
 * 
 * Salário                              Bonificação
 * Até R$ 500,00                        5% do salário
 * Entre R$ 500,00 e R$ 1.200,00        12% do salário
 * Acima de R$ 1.200,00                 Sem bonificação
 * 
 * Salário                              Auxílio Escola
 * Até R$ 600,00                        R$ 150,00
 * Acima de R$ 600,00                   R$ 100,00
*/

using System;

class B14
{
    static void Main(string[] args)
    {
        double sal, nSal;

        sal = int.Parse(Console.ReadLine());

        if (sal <= 500.00)
        {
            nSal = sal + sal * 0.05 + 150.00;
        }
        else
        {
            nSal = (sal <= 600.00)
                ? sal + sal * 0.12 + 150.00
                : sal + sal * 0.12 + 100.00;
        }

        Console.WriteLine($"{nSal:C}");
    }
}