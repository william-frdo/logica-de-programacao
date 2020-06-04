/* C22
 * Uma empresa decidiu fazer um levantamento em relação aos candidatos que se apresentarem para
 * preenchimento de vagas em seu quadro de funcionários. Supondo que você seja o programador
 * dessa empresa, faça um programa que leia, para cada candidato, a idade, o sexo (M ou F) e a
 * experiência no serviço (S ou N). Para encerrar a entrada de dados, digite zero para a idade.
 * O programa também deve calcular e mostrar:
 * o número de candidatos do sexo feminino;
 * o número de candidatos do sexo masculino;
 * a idade média dos homens que já têm experiência no serviço;
 * a porcentagem dos homens com mais de 45 anos entre o total dos homens;
 * o número de mulheres com idade inferior a 21 anos e com experiência no serviço;
 * a menor idade entre as mulheres que já têm experiência no serviço.
 */

using System;

class C22
{
    static void Main(string[] args)
    {
        int idade, qtdF, qtdM, qtdMExp,qtdMaior45, percH, somaIdadeH, idadeMediaH, qtdMenor21, menorIdade;
        char sexo, exp;

        Console.WriteLine("Informe a idade o sexo (M/F) e a experiência (S/N). Para encerra digite 0 para a idade.");
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        qtdF = 0;
        qtdM = 0;
        qtdMExp = 0;
        somaIdadeH = 0;
        qtdMaior45 = 0;
        qtdMenor21 = 0;
        menorIdade = idade;

        while (idade != 0)
        {
            Console.Write("Sexo: ");
            sexo = char.Parse(Console.ReadLine());
            Console.Write("Experiência: ");
            exp = char.Parse(Console.ReadLine());

            if (sexo == 'F')
            {
                qtdF++;

                if (exp == 'S')
                {
                    if (idade < menorIdade)
                    {
                        menorIdade = idade;
                    }

                    if (idade <= 21)
                    {
                        qtdMenor21++;
                    }
                }
            }
            else
            {
                qtdM++;

                if (exp == 'S')
                {
                    somaIdadeH += idade;
                    qtdMExp++;
                }

                if (idade >= 45)
                {
                    qtdMaior45++;
                }
            }

            Console.Write("Idade: ");
            idade = int.Parse(Console.ReadLine());
        }

        idadeMediaH = somaIdadeH / qtdMExp;
        percH = qtdMaior45 * 100 / qtdM;

        Console.WriteLine($"Quantidade de candidados do sexo feminino: {qtdF}");
        Console.WriteLine($"Quantidade de candidados do sexo masculino: {qtdM}");
        Console.WriteLine($"Idade média de homens com experiência: {idadeMediaH}");
        Console.WriteLine($"Porcentagem de homens com mais de 45 anos: {percH}%");
        Console.WriteLine($"Quantidade de mulheres com idade inferior a 21 anos e experiência : {qtdMenor21}");
        Console.WriteLine($"Menor idade da mulher experiência : {menorIdade}");
    }
}
