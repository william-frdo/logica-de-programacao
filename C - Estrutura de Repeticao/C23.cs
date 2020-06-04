/* C23
 * Faça um programa que receba o valor do salário mínimo, uma lista contendo a quantidade de quilowatts gasta por
 * consumidor e o tipo de consumidor (1 — residencial; 2 — comercial; ou 3 — industrial) e que calcule e mostre:
 * o valor de cada quilowatt, sabendo que o quilowatt custa um oitavo do salário mínimo;
 * o valor a ser pago por consumidor (conta final mais acréscimo). O acréscimo encontra-se na tabela a seguir:
 * TIPO    | % DE ACRÉSCIMO SOBRE O VALOR GASTO
 * 1       | 5
 * 2       | 10
 * 3       | 15
 * o faturamento geral da empresa;
 * a quantidade de consumidores que pagam entre R$ 500,00 e R$ 1.000,00.
 * Termine a entrada de dados com quantidade de quilowats igual a zero.
 */

using System;

class C23
{
    static void Main(string[] args)
    {
        float sal, kwatts, vKwatts, conta, faturamento;
        int tipo, qtdConsumidor;

        faturamento = 0;
        qtdConsumidor = 0;

        Console.Write("Valor do salário mínimo: ");
        sal = float.Parse(Console.ReadLine());
        Console.Write("Quantidade de quilowatts gasta no mês: ");
        kwatts = float.Parse(Console.ReadLine());

        while (kwatts != 0)
        {
            Console.Write("Tipo (1 - Residencial; 2 - Comercial; 3 - Industrial): ");
            tipo = int.Parse(Console.ReadLine());

            vKwatts = sal / 8;
            conta = vKwatts * kwatts;

            if (tipo == 1)
            {
                conta += conta * 5 / 100;
            }

            if (tipo == 2)
            {
                conta += conta * 10 / 100;
            }

            if (tipo == 3)
            {
                conta += conta * 15 / 100;
            }

            if (conta >= 500.00 && conta <= 1000.00)
            {
                qtdConsumidor++;
            }

            faturamento += conta;

            Console.WriteLine($"Valor do quilowatts: {vKwatts:C}");
            Console.WriteLine($"Valor a ser pago: {conta:C}");
            Console.WriteLine();
            Console.Write("Quantidade de quilowatts gasta no mês: ");
            kwatts = float.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Faturamento da empresa: {faturamento:C}");
        Console.WriteLine($"Quantidade de consumidores que pagam entre R$500.00 e R$1000.00: {qtdConsumidor}");
    }
}
