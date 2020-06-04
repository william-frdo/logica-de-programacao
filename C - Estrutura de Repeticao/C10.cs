/* C10
   Em um campeonato de futebol existem cinco times e cada um possui onze jogadores. Faça um
   programa que receba a idade, o peso e a altura de cada um dos jogadores, calcule e mostre:
   a quantidade de jogadores com idade inferior a 18 anos;
   a média das idades dos jogadores de cada time;
   a média das alturas de todos os jogadores do campeonato; e
   a porcentagem de jogadores com mais de 80 kg entre todos os jogadores do campeonato.
*/

using System;

class C10
{
    static void Main(string[] args)
    {
        int idade, qtdMenor18 = 0;
        double peso, altura, medIdade, medAltura = 0, maisDe80kg = 0;

        for (int i = 1; i <= 5; i++)
        {
            medIdade = 0;

            for (int j = 1; j <= 11; j++)
            {
                idade = int.Parse(Console.ReadLine());
                peso = float.Parse(Console.ReadLine());
                altura = float.Parse(Console.ReadLine());

                if (idade < 18)
                {
                    qtdMenor18++;
                }

                medIdade += idade;
                medAltura += altura;

                if (peso > 80)
                {
                    maisDe80kg++;
                }
            }

            medIdade /= 11;

            Console.WriteLine($"Média idade do {i}º time: {medIdade:F2}");
        }

        medAltura /= 55;
        maisDe80kg = maisDe80kg * 100 / 55;

        Console.WriteLine($"{qtdMenor18}");
        Console.WriteLine($"{medAltura:F2}");
        Console.WriteLine($"{maisDe80kg:F2}");
    }
}