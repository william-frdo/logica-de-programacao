/* C20
 * Faça um programa para ler o código, o sexo (M — masculino; F — feminino) e o
 * número de horas/aula dadas mensalmente pelos professores de uma universidade,
 * sabendo-se que cada hora/aula vale R$ 30,00. Emita uma listagem contendo o
 * código, o salário bruto e o salário líquido (levando em consideração os descontos
 * explicados a seguir) de todos os professores. Mostre também a média dos salários
 * líquidos dos professores do sexo masculino e a média dos salários líquidos dos
 * professores do sexo feminino. Considere:
 * desconto para homens, 10%, e, para mulheres, 5%;
 * as informações terminarão quando for lido o código = 99999.
 */

using System;

class C20
{
    static void Main(string[] args)
    {
        int cod, horas;
        double salB, salL, medM, medF, somaM, somaF;
        char sexo;

        medM = 0;
        medF = 0;
        somaM = 0;
        somaF = 0;

        Console.Write("Código: ");
        cod = int.Parse(Console.ReadLine());

        while (cod != 99999)
        {
            Console.Write("Sexo(M/F): ");
            sexo = char.Parse(Console.ReadLine());
            Console.Write("Horas: ");
            horas = int.Parse(Console.ReadLine());

            salB = horas * 30.00;

            if (sexo == 'M') {
                salL = salB - salB * 0.1;
                medM++;
                somaM += salL;
            }
            else
            {
                salL = salB - salB * 0.05;
                medF++;
                somaF += salL;
            }

            Console.WriteLine($"Código: {cod}");
            Console.WriteLine($"Salário bruto: {salB:C}");
            Console.WriteLine($"Salário líquido: {salL:C}");
            Console.WriteLine();
            Console.Write("Código: ");
            cod = int.Parse(Console.ReadLine());                
        }

        medM = somaM / medM;
        medF = somaF / medF;

        Console.WriteLine($"Média dos salários dos professores: {medM:C}");
        Console.WriteLine($"Média dos salários das professoras: {medF:C}");
    }
}