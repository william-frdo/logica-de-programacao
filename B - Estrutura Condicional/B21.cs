/* B21
 * Faça um programa que receba:
 * o código do estado de origem da carga de um caminhão, supondo que a digitação do código do estado seja sempre válida, isto é, um número inteiro entre 1 e 5;
 * o peso da carga do caminhão em toneladas;
 * o código da carga, supondo que a digitação do código seja sempre válida, isto é, um número inteiro entre 10 e 40.
 * 
 * Tabelas:
 * Código do estado  Iposto         Código da carga  Preço por quilo
 * 1                 35%            10 a 20          100
 * 2                 25%            21 s 30          250
 * 3                 15%            31 a 40          340
 * 4                 5%
 * 5                 Isento
 * 
 * calcule e mostre:
 * o peso da carga do caminhão convertido em quilos;
 * o preço da carga do caminhão;
 * o valor do imposto, sabendo que o imposto é cobrado sobre o preço da carga do caminhão e depende do estado de origem;
 * o valor total transportado pelo caminhão, preço da carga mais imposto
 */

using System;

class B21
{
    static void Main(string[] args)
    {
        int cod, codProd;
        double ton, imp, kg, preco = 0, precoTotal;


        cod = int.Parse(Console.ReadLine());
        ton = double.Parse(Console.ReadLine());
        codProd = int.Parse(Console.ReadLine());

        kg = ton * 1000;

        if (codProd >= 10 && codProd <= 20)
        {
            preco = kg * 100;
        }
        else if (codProd <= 30)
        {
            preco = kg * 250;
        }
        else if (codProd <= 40)
        {
            preco = kg * 340;
        }

        switch (cod)
        {
            case 1:
                imp = preco * 0.35;
                break;

            case 2:
                imp = preco * 0.25;
                break;

            case 3:
                imp = preco * 0.15;
                break;

            case 4:
                imp = preco * 0.05;
                break;

            default:
                imp = 0;
                break;
        }

        precoTotal = preco + imp;

        Console.WriteLine($"{kg:F2}");
        Console.WriteLine($"{preco:C}");
        Console.WriteLine($"{imp:C}");
        Console.WriteLine($"{precoTotal:C}");
    }
}