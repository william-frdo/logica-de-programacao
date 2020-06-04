/* B22
 * Faça um programa que receba o salário base e o tempo de serviço de um funcionário.
 * Calcule e mostre: O imposto, conforme a tabela a seguir.
 * 
 * SALÁRIO BASE                                           % SOBRE O SALÁRIO BASE
 * < R$ 200,00                                            isento
 * Entre R$ 200,00 (inclusive) e R$ 450,00 (inclusive)    3%
 * Entre R$ 450,00 e R$ 700,00                            8%
 * >= R$ 700,00                                           12%
 * 
 * A gratificação, de acordo com a tabela a seguir.
 * SALÁRIO BASE            TEMPO DE SERVIÇO      GRATIFICAÇÃO
 * Superior a R$ 500,00    Até 3 anos            20
 *                         Mais de 3 anos        30
 *
 * Até R$ 500,00           Até 3 anos            23
 *                         Entre 3 e 6 anos      35
 *                         De 6 anos para cima   33
 *                         
 * O salário líquido, ou seja, salário base menos imposto mais gratificação.
 * A categoria, que está na tabela a seguir.
 * SALÁRIO LÍQUIDO                CLASSIFICAÇÃO
 * Até R$ 350,00                  A
 * Entre R$ 350,00 e R$ 600,00    B
 * De R$ 600,00 para cima         C
 */

using System;

class B22
{
    static void Main(string[] args)
    {
        int tempServ, grat = 0;
        double sal, sLiquido, imp;
        char categ;

        sal = double.Parse(Console.ReadLine());
        tempServ = int.Parse(Console.ReadLine());

        if (sal >= 200 && sal < 450)
        {
            imp = sal * 0.03;
        }
        else if (sal < 700)
        {
            imp = sal * 0.08;
        }
        else if (sal >= 700)
        {
            imp = sal * 0.12;
        }
        else
        {
            imp = 0;
        }

        if (sal > 500)
        {
            grat = (tempServ <= 3) ? 20 : 30;
        }
        else
        {
            if (tempServ <= 3)
            {
                grat = 23;
            }
            else if (tempServ < 6)
            {
                grat = 35;
            }
        }

        sLiquido = sal - imp + grat;

        if (sLiquido <= 350)
        {
            categ = 'A';
        }
        else
        {
            categ = (sLiquido <= 600) ? 'B' : 'C';
        }

        Console.WriteLine($"{imp:C}");
        Console.WriteLine($"{grat:C}");
        Console.WriteLine($"{sLiquido:C}");
        Console.WriteLine(categ);
    }
}