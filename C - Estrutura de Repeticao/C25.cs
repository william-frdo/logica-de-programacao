/* C25
 * Faça um programa que receba os dados a seguir de vários produtos: preço unitário, país de
 * origem (1 – Estados Unidos; 2 — México; e 3 — outros), meio de transporte (T — terrestre;
 * F — fluvial; e A — aéreo), carga perigosa (S — sim; N — não), finalize a entrada de dados
 * com um preço inválido, ou seja, menor ou igual a zero. O programa deve calcular e mostrar
 * os itens a seguir.
 * O valor do imposto, usando a tabela a seguir.
 * PREÇO UNITÁRIO       | PERCENTUAL DE IMPOSTO SOBRE O PREÇO UNITÁRIO
 * Até R$ 100,00        | 5%
 * Maior que R$ 100,00  | 10%
 * 
 * O valor do transporte usando a tabela a seguir.
 * CARGA PERIGOSA   | PAÍS DE ORIGEM    | VALOR DO TRANSPORTE
 * S                | 1                 | R$ 50,00
 *                  | 2                 | R$ 21,00
 *                  | 3                 | R$ 24,00
 * ----------------------------------------------------------
 * N                | 1                 | R$ 12,00
 *                  | 2                 | R$ 21,00
 *                  | 3                 | R$ 60,00
 *                  
 * O valor do seguro, usando a regra a seguir.
 * Os produtos que vêm do México e os produtos que utilizam transporte aéreo pagam metade do
 * valor do seu preço unitário como seguro.
 * O preço final, ou seja, preço unitário mais imposto mais valor do transporte mais valor do
 * seguro.
 * O total dos impostos.
 */

using System;

class C25
{
    static void Main(string[] args)
    {
        double preco, precoFinal, imp, totImp, vTransp, seguro;
        int origem;
        char transp, perigosa;

        vTransp = 0;
        totImp = 0;

        Console.Write("Preço unitário: ");
        preco = double.Parse(Console.ReadLine());

        while (preco > 0)
        {
            Console.Write("País (1 - Estados Unidos; 2 - México; 3 - Outros): ");
            origem = int.Parse(Console.ReadLine());
            Console.Write("Transporte (T - terrestre; F - fluvial; A - aéreo): ");
            transp = char.Parse(Console.ReadLine());
            Console.Write("Carga perigosa (S - sim; N - não): ");
            perigosa = char.Parse(Console.ReadLine());

            if (preco <= 100)
            {
                imp = preco * 5 / 100;
            }
            else
            {
                imp = preco * 10 / 100;
            }

            if (perigosa == 'S')
            {
                if (origem == 1)
                {
                    vTransp = 50;
                }
                
                if (origem == 2)
                {
                    vTransp = 21;
                }

                if (origem == 3)
                {
                    vTransp = 24;
                }
            }
            else
            {
                if (origem == 1)
                {
                    vTransp = 12;
                }

                if (origem == 2)
                {
                    vTransp = 21;
                }

                if (origem == 3)
                {
                    vTransp = 60;
                }
            }

            if (origem == 2 || transp == 'A')
            {
                seguro = preco / 2;
            }
            else
            {
                seguro = 0;
            }

            precoFinal = preco + imp + vTransp + seguro;
            totImp += imp;

            Console.WriteLine($"Valor do imposto: {imp:C}");
            Console.WriteLine($"Valor do transporte: {vTransp:C}");
            Console.WriteLine($"Valor do seguro: {seguro:C}");
            Console.WriteLine($"Preço final: {precoFinal:C}");

            Console.Write("Preço unitário: ");
            preco = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Total de impostos: {totImp:C}");
    }
}
