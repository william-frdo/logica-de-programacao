/* B24
 * Faça um programa que receba o preço, o tipo (A — alimentação; l — limpeza; e v — vestuário) e a
 * refrigeração (S — produto que necessita de refrigeração; e N — produto que não necessita de refrigeração)
 * de um produto. Suponha que haverá apenas a digitação de dados válidos e, quando houver digitação de letras,
 * utilize maiúsculas. calcule e mostre:
 * O valor adicional, de acordo com a tabela a seguir:
 * REFRIGERAÇÃO | TIPO | PREÇO       | VALOR ADICIONAL
 * ---------------------------------------------------
 * N            | A    | < R$ 15,00  | R$ 2,00
 *              |      | >= R$ 15,00 | R$ 5,00
 *              --------------------------------------
 *              | L    | < R$ 10,00  | R$ 1,50
 *              |      | >= R$ 10,00 | R$ 2,50
 *              --------------------------------------
 *              | V    | < R$ 30,00  | R$ 3,00
 *              |      | >= R$ 30,00 | R$ 2,50
 * ---------------------------------------------------
 * S            | A    |             | R$ 8,00
 *              --------------------------------------
 *              | L    |             | R$ 0,00
 *              --------------------------------------
 *              | V    |             | R$ 0,00
 * 
 * O valor do imposto, de acordo com a regra a seguir.
 * PREÇO       | PERCENTUAL SOBRE O PREÇO
 * --------------------------------------
 * < R$ 25,00  | 5%
 * --------------------------------------
 * >= R$ 25,00 | 8%
 * 
 * O preço de custo, ou seja, preço mais imposto.
 * O desconto, de acordo com a regra a seguir.
 * O produto que não preencher nenhum dos requisitos a seguir terá desconto de 3%, caso contrário, 0 (zero).
 * Os requisitos são:
 * Tipo: A
 * Refrigeração: S
 * O novo preço, ou seja, preço de custo mais adicional menos desconto.
 * A classificação, de acordo com a regra a seguir.
 * NOVO                       | PREÇO CLASSIFICAÇÃO
 * ------------------------------------------------
 * < = R$ 50,00               | Barato
 * ------------------------------------------------
 * Entre R$ 50,00 e R$ 100,00 | Normal
 * ------------------------------------------------
 * >= R$ 100,00               | Caro
 */

using System;

class B24
{
    static void Main(string[] args)
    {
        double preco, nPreco, pCusto, vAdicional, imp, desc = 0.00;
        char tipo, refrigeracao;

        preco = double.Parse(Console.ReadLine());
        tipo = char.Parse(Console.ReadLine());
        refrigeracao = char.Parse(Console.ReadLine());

        switch (refrigeracao)
        {
            case 'N':
                switch (tipo)
                {
                    case 'A':
                        vAdicional = (preco >= 15) ? 5.00 : 2.00;
                        break;

                    case 'L':
                        vAdicional = (preco >= 10) ? 2.50 : 1.50;
                        break;

                    case 'V':
                        vAdicional = (preco >= 30) ? 2.50 : 3.00;
                        break;

                    default:
                        vAdicional = 0.00;
                        break;
                }
                break;

            case 'S':
                switch (tipo)
                {
                    case 'A':
                        vAdicional = 8.00;
                        break;

                    default:
                        vAdicional = 0.00;
                        break;
                }
                break;

            default:
                vAdicional = 0.00;
                break;
        }

        Console.WriteLine($"{vAdicional:C}");

        imp = (preco >= 25) ? preco * 0.08 : preco * 0.05;
        Console.WriteLine($"{imp:C}");

        pCusto = preco + imp;
        Console.WriteLine($"{pCusto:C}");

        if (tipo != 'A' && refrigeracao != 'S')
        {
            desc = pCusto * 0.03;
        }

        Console.WriteLine($"{desc:C}");

        nPreco = pCusto + vAdicional - desc;
        Console.WriteLine($"{nPreco:C}");

        if (nPreco <= 50)
        {
            Console.WriteLine("Barato");
        }
        else if (nPreco > 50 && nPreco < 100)
        {
            Console.WriteLine("Normal");
        }
        else
        {
            Console.WriteLine("Caro");
        }
    }
}