/* C14
 * Faça um programa que receba o valor de uma dívida e mostre uma tabela com os seguintes dados:
 * valor da dívida, valor dos juros, quantidade de parcelas e valor da parcela.
 * Os juros e a quantidade de parcelas seguem a tabela:
 * QUANTIDADE DE PARCELAS | % DE JUROS SOBRE O VALOR INICIAL DA DÍVIDA
 * 1                      | 0
 * 3                      | 10
 * 6                      | 15
 * 9                      | 20
 * 12                     | 25
 * 
 * Exemplo de saída do programa:
 * VALOR DA DÍVIDA | VALOR DOS JUROS | QUANTIDADE DE PARCELAS | VALOR DA PARCELA
 * R$ 1.000,00     | 0               | 1                      | R$ 1.000,00
 * R$ 1.100,00     | 100             | 3                      | R$ 366,67
 * R$ 1.150,00     | 150             | 6                      | R$ 191,67
 */

using System;

class C14
{
    static void Main(string[] args)
    {
        int qtdParcela = 1;
        double vInicial, divida, vJuros, vParcela, porcentagem = 0;

        Console.Write("Valor da dívida: ");
        divida = double.Parse(Console.ReadLine());
        vInicial = divida;

        Console.WriteLine("VALOR DA DÍVIDA | VALOR DOS JUROS | QUATIDADE DE PARCELAS | VALOR DA PARCELA");
        
        for (int i = 0; i < 5; i++)
        {
            vJuros = vInicial * porcentagem / 100;
            divida = vInicial + vJuros;
            vParcela = divida / qtdParcela;

            Console.WriteLine($"{divida:C}\t\t{vJuros:F2}\t\t{qtdParcela}\t\t\t{vParcela:C}");
            
            if (porcentagem == 0)
            {
                porcentagem += 10.0;
            }
            else
            {
                porcentagem += 5;
            }

            if (qtdParcela == 1)
            {
                qtdParcela += 2;
            }
            else
            {
                qtdParcela += 3;
            }
        }
    }
}