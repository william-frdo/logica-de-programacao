/* C15
 * Faça um programa que receba o preço unitário, a refrigeração(S para os produtos que
 * necessitem de refrigeração e N para os que não necessitem) e a categoria (A — alimentação;
 * L — limpeza; e V — vestuário) de doze produtos, e que calcule e mostre:
 * O custo de estocagem, calculado de acordo com a tabela a seguir.
 * 
 * PREÇO UNITÁRIO            | REFRIGERAÇÃO | CATEGORIA | CUSTO DE ESTOCAGEM
 * Até 20                    |              | A         | R$ 2,00
 *                           |              | L         | R$ 3,00
 *                           |              | V         | R$ 4,00
 * -------------------------------------------------------------------------
 * Entre 20 e 50 (inclusive) | S            |           | R$ 6,00
 *                           | N            |           | R$ 0,00
 * -------------------------------------------------------------------------
 * Maior que 50              | S            | A         | R$ 5,00
 *                           |              | L         | R$ 2,00
 *                           |              | V         | R$ 4,00
 *                           |--------------|-----------|
 *                           | N            | A ou V    | R$ 0,00
 *                           |              | L         | R$ 1,00
 *  
 * O imposto calculado de acordo com as regras a seguir:
 * Se o produto não preencher nenhum dos requisitos a seguir, seu imposto será de 2% sobre o
 * preço unitário; caso contrário, será de 4%.
 * Os requisitos são: categoria — A e refrigeração — S.
 * O preço final, ou seja, preço unitário mais custo de estocagem mais imposto.
 * A classificação calculada usando a tabela a seguir.
 * 
 * PREÇO FINAL                            | CLASSIFICAÇÃO
 * Até R$ 20,00                           | Barato
 * Entre R$ 20,00 e R$ 100,00 (inclusive) | Normal
 * Acima de R$ 100,00                     | Caro
 * 
 * A média dos valores adicionais, ou seja, a média dos custos de estocagem e dos impostos dos
 * doze produtos.
 * O maior preço final.
 * O menor preço final.
 * O total dos impostos.
 * A quantidade de produtos com classificação barato.
 * A quantidade de produtos com classificação caro.
 * A quantidade de produtos com classificação normal.
 */

using System;

class C15
{
    static void Main(string[] args)
    {
        double preco, custoEst, imp, precoFinal, adicional;
        double maiorP, menorP, totImp, qtdB, qtdN, qtdC;
        char refri, categ;

        adicional = 0;
        totImp = 0;
        qtdB = 0;
        qtdN = 0;
        qtdC = 0;
        custoEst = 0;
        maiorP = 0;
        menorP = 0;

        for (int i = 1; i <= 12; i++)
        {
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Refrigeração (S/N): ");
            refri = char.Parse(Console.ReadLine());
            Console.Write("Categoria (A/L/V): ");
            categ = char.Parse(Console.ReadLine());

            if (preco <= 20)
            {
                if (categ == 'A')
                {
                    custoEst = 2;
                }

                if (categ == 'L')
                {
                    custoEst = 3;
                }

                if (categ == 'V')
                {
                    custoEst = 4;
                }
            }
            else if (preco <= 50)
            {
                if (refri == 'S')
                {
                    custoEst = 6;
                }
                else
                {
                    custoEst = 0;
                }
            }
            else
            {
                if (refri == 'S')
                {
                    if (categ == 'A')
                    {
                        custoEst = 5;
                    }
                    
                    if (categ == 'L')
                    {
                        custoEst = 2;
                    }

                    if (categ == 'V')
                    {
                        custoEst = 4;
                    }
                }
                else
                {
                    if (categ == 'A' || categ == 'V')
                    {
                        custoEst = 0;
                    }

                    if (categ == 'L')
                    {
                        custoEst = 1;
                    }
                }
            }

            if (categ != 'A' && refri != 'S')
            {
                imp = preco * 2 / 100;
            }
            else
            {
                imp = preco * 4 / 100;
            }

            precoFinal = preco + custoEst + imp;

            Console.WriteLine($"Custo estimado: {custoEst:C}");
            Console.WriteLine($"Imposto: {imp}");
            Console.WriteLine($"Preço final: {precoFinal:C}");

            if (precoFinal <= 20)
            {
                qtdB += 1;
                Console.WriteLine("Classificação Barato");
            }
            else if (precoFinal <= 100)
            {
                qtdN += 1;
                Console.WriteLine("Classificação Normal");
            }
            else
            {
                qtdC += 1;
                Console.WriteLine("Classificação Caro");
            }

            adicional += custoEst + imp;
            totImp += imp;

            if (i == 1)
            {
                maiorP = precoFinal;
                menorP = precoFinal;
            }
            else
            {
                if (precoFinal > maiorP)
                {
                    maiorP = precoFinal;
                }
                else
                {
                    menorP = precoFinal;
                }
            }
        }

        adicional /= 12;

        Console.WriteLine($"Adicional: {adicional:C}");
        Console.WriteLine($"Maior preço: {maiorP:C}");
        Console.WriteLine($"Menor preço: {menorP:C}");
        Console.WriteLine($"Total de impostos: {totImp:C}");
        Console.WriteLine($"Quantidade barato: {qtdB}");
        Console.WriteLine($"Quantidade normal: {qtdN}");
        Console.WriteLine($"Quantidade caro: {qtdC}");
    }
}