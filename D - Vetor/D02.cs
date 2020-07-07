/* D02
 * Uma pequena loja de artesanato possui apenas um vendedor e comercializa dez tipos de objetos.
 * O vendedor recebe, mensalmente, salário de R$ 545,00, acrescido de 5% do valor total de suas
 * vendas. O valor unitário dos objetos deve ser informado e armazenado em um vetor; a quantidade
 * vendida de cada peça deve ficar em outro vetor, mas na mesma posição. Crie um programa que
 * receba os preços e as quantidades vendidas, armazenando-os em seus respectivos vetores (ambos
 * com tamanho dez).
 * Depois, determine e mostre:
 * um relatório contendo: quantidade vendida, valor unitário e valor total de cada objeto. Ao
 * final, deverão ser mostrados o valor geral das vendas e o valor da comissão que será paga ao
 * vendedor; e 
 * o valor do objeto mais vendido e sua posição no vetor (não se preocupe com empates).
 */

using System;
using System.Globalization;

namespace D02
{
    class D02
    {
        static void Main(string[] args)
        {
            // Necessário para entrada de valures com ","
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            int posicao = 0, qtdMaisVendido = 0;
            double vGeral = 0, comissao;
            int[] qtd = new int[10];
            double[] valor = new double[10];

            for (int i = 0; i < qtd.Length; i++)
            {
                Console.Write($"Quantidade vendida do {i + 1}º produto: ");
                qtd[i] = int.Parse(Console.ReadLine());
                Console.Write($"Valor do {i + 1}º produto: ");
                valor[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < qtd.Length; i++)
            {
                if (i == 0)
                {
                    posicao = i + 1;
                    qtdMaisVendido = qtd[i];
                }

                if (qtd[i] > qtdMaisVendido)
                {
                    posicao = i + 1;    
                    qtdMaisVendido = qtd[i];
                }

                double soma = qtd[i] * valor[i];
                vGeral += soma;
                Console.WriteLine($"Quantidade vendida: {qtd[i]}");
                Console.WriteLine($"Valor unitário: {valor[i]:C}");
                Console.WriteLine($"Valor total: {soma:C}");
            }

            Console.WriteLine($"Valor geral das vendas: {vGeral:C}");
            comissao = vGeral * 0.05;
            Console.WriteLine($"Valor da comissão: {comissao:C}");
            Console.WriteLine($"Quantidade do objeto mais vendido foi {qtdMaisVendido}, na posisao {posicao}");
        }
    }
}
