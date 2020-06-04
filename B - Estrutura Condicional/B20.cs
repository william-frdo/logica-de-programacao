/* B20
 * Faça um programa que receba:
 * O código de um produto comprado, supondo que a digitação do código do produto seja sempre válida, isto é, um número inteiro entre 1 e 10.
 * O peso do produto em quilos.
 * O código do país de origem, supondo que a digitação do código seja sempre válida, isto é, um número inteiro entre 1 e 3.
 * 
 * Tabelas:
 * Códogo do páis de origem  Iposto         Código do produto  Preço por grama
 * 1                         0%             1 a 4              10 
 * 2                         15%            5 a 7              25
 * 3                         25%            8 a 10             35
 * 
 * Calcule e mostre:
 * o peso do produto convertido em gramas;
 * o preço total do produto comprado;
 * o valor do imposto, sabendo que ele é cobrado sobre o preço total do produto comprado e depende do país de origem;
 * o valor total, preço total do produto mais imposto.
 */

using System;

class B20
{
    static void Main(string[] args)
    {
        int codProd, codPais;
        double kg, gr, imp, precoProd, precoTotal;

        codProd = int.Parse(Console.ReadLine());
        kg = double.Parse(Console.ReadLine());
        codPais = int.Parse(Console.ReadLine());

        gr = kg * 1000;
        imp = 0;

        if (codProd >= 1 && codProd <= 4)
        {
            precoProd = gr * 10;
        }
        else if (codProd <= 7)
        {
            precoProd = gr * 25;
        }
        else
        {
            precoProd = gr * 35;
        }

        switch (codPais)
        {
            case 2:
                imp = 0.15 * precoProd;
                break;

            case 3:
                imp = 0.25 * precoProd;
                break;

            default:
                break;
        }

        precoTotal = precoProd + imp;

        Console.WriteLine($"{gr:F2}");
        Console.WriteLine($"{precoProd:C}");
        Console.WriteLine($"{imp:C}");
        Console.WriteLine($"{precoTotal:C}");
    }
}