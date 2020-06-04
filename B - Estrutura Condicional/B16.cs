/* B16
 * Um supermercado deseja reajustar os preços de seus produtos usando o seguinte critério:
 * O produto poderá ter seu preço aumentado ou diminuído.
 * Para o preço ser alterado, o produto deve preencher pelo menos um dos requisitos a seguir:
 * 
 * VENDA MÉDIA MENSAL   PREÇO ATUAL                 % DE AUMENTO    % DE DIMINUIÇÃO
 * < 500                < R$ 30,00                  10              –
 * >= 500 e < 1.200     >= R$ 30,00 e < R$ 80,00    15              –
 * >= 1.200             >= R$ 80,00                 –               20
 * 
 * Faça um programa que receba o preço atual e a venda média mensal do produto, calcule e mostre o novo preço.
 */

using System;

class B16
{
    static void Main(string[] args)
    {
        double preco = double.Parse(Console.ReadLine());
        int vMensal = int.Parse(Console.ReadLine());

        if (vMensal < 500 || preco < 30.00)
        {
            preco += preco * 0.1;
        }

        if (vMensal >= 500 && vMensal < 1200 || preco >= 30.00 && preco < 80.00)
        {
            preco += preco * 0.15;
        }

        if (vMensal >= 1200 || preco >= 80.00)
        {
            preco -= preco * 0.2;
        }

        Console.WriteLine($"{preco:C}");
    }
}