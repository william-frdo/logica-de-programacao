/* B15
 * Faça um programa que receba o valor do salário mínimo, o número de horas trabalhadas, o número de dependentes do
 * funcionário e a quantidade de horas extras trabalhadas. Calcule e mostre o salário a receber do funcionário de
 * acordo com as regras a seguir:
 * O valor da hora trabalhada é igual a 1/5 do salário mínimo.
 * O salário do mês é igual ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada.
 * Para cada dependente, acrescentar R$ 32,00.
 * Para cada hora extra trabalhada, calcular o valor da hora trabalhada acrescida de 50%.
 * O salário bruto é igual ao salário do mês mais o valor dos dependentes mais o valor das horas extras.
 * calcular o valor do imposto de renda retido na fonte de acordo com a tabela a seguir:
 * IRRF                     Salário Bruto
 * Isento                   Inferior a R$ 200,00
 * 10%                      De R$ 200,00 até R$ 500,00
 * 20%                      Superior a R$ 500,00
 * 
 * O salário líquido é igual ao salário bruto menos IRRF.
 * A gratificação é de acordo com a tabela a seguir:
 * Salário                  Líquido Gratificação
 * Até R$ 350,00            R$ 100,00
 * Superior a R$ 350,00     R$ 50,00
 * 
 * O salário a receber do funcionário é igual ao salário líquido mais a gratificação.
 */

using System;

class B15
{
    static void Main(string[] args)
    {
        int dependentes;
        double hora, hExtra, sal, sBruto, sLiquido, IRRF = 0;

        sal = double.Parse(Console.ReadLine());
        hora = int.Parse(Console.ReadLine());
        dependentes = int.Parse(Console.ReadLine());
        hExtra = int.Parse(Console.ReadLine());

        hora *= sal * 0.2;
        hExtra *= sal * 0.2;
        hExtra += hExtra * 0.5;
        sBruto = hora + hExtra + dependentes * 32.00;

        if (sBruto >= 200.00 && sBruto <= 500.00)
        {
            IRRF = sBruto * 0.1;
        }

        if (sBruto >= 500.00)
        {
            IRRF = sBruto * 0.2;
        }

        sLiquido = sBruto - IRRF;

        sLiquido = (sLiquido <= 350.00) ? sLiquido + 100.00 : sLiquido + 50.00;

        Console.WriteLine($"{sLiquido:C}");
    }
}