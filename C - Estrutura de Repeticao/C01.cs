/* C01
   Um funcionário de uma empresa recebe, anualmente, aumento salarial. Sabe-se que:
   a) Esse funcionário foi contratado em 2005, com salário inicial de R$ 1.000,00.
   b) Em 2006, ele recebeu aumento de 1,5% sobre seu salário inicial.
   c) A partir de 2007 (inclusive), os aumentos salariais sempre corresponderam ao dobro
   do percentual do ano anterior.
   Faça um programa que determine o salário atual desse funcionário.
*/

using System;

class C01
{
    static void Main(string[] args)
    {
        int anoAtual = int.Parse(Console.ReadLine());
        double perc = 0.015;
        double sal = 1000.00;
        double aumento = sal * perc;

        for (int i = 2006; i <= anoAtual; i++)
        {
            sal += aumento;
            perc *= 2;
            aumento = sal * perc;
        }

        Console.WriteLine($"{sal:C}");
    }
}