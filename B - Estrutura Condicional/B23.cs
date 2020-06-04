/* B23
 * Faça um programa que receba o valor do salário mínimo, o turno de trabalho (M — matutino; V — vespertino;
 * ou N — noturno), a categoria (O — operário; G — gerente) e o número de horas trabalhadas no mês de um funcionário.
 * Suponha a digitação apenas de dados válidos e, quando houver digitação de letras, utilize maiúsculas.
 * Calcule e mostre: O coeficiente do salário, de acordo com a tabela a seguir.
 * 
 * TURNO DE TRABALHO    VALOR DO COEFICIENTE
 * M — Matutino         10% do salário mínimo
 * V — Vespertino       15% do salário mínimo
 * N — Noturno          12% do salário mínimo
 * 
 * O valor do salário bruto, ou seja, o número de horas trabalhadas multiplicado pelo valor do coeficiente do salário.
 * O imposto, de acordo com a tabela a seguir.
 * 
 * CATEGORIA        SALÁRIO BRUTO       IMPOSTO SOBRE O SALÁRIO BRUTO
 * O — Operário     >= R$ 300,00        5%
 *                  < R$ 300,00         3%
 *                  
 * G — Gerente      >= R$ 400,00        6%
 *                  < R$ 400,00         4%
 * 
 * A gratificação, de acordo com as regras a seguir.
 * Se o funcionário preencher todos os requisitos a seguir, sua gratificação será de R$ 50,00; caso contrário, será
 * de R$ 30,00. Os requisitos são:
 * Turno: Noturno
 * Número de horas trabalhadas: Superior a 80 horas
 * O auxílio alimentação, de acordo com as seguintes regras.
 * Se o funcionário preencher algum dos requisitos a seguir, seu auxílio alimentação será de um terço do seu salário
 * bruto; caso contrário, será de metade do seu salário bruto. Os requisitos são:
 * Categoria: Operário
 * Coeficiente do salário: < = 25
 * O salário líquido, ou seja, salário bruto menos imposto mais gratificação mais auxílio alimentação.
 * A classificação, de acordo com a tabela a seguir:
 * 
 * SALÁRIO LÍQUIDO                   MENSAGEM
 * Menor que R$ 350,00               Mal remunerado
 * Entre R$ 350,00 e R$ 600,00       Normal
 * Maior que R$ 600,00               Bem remunerado
 */

using System;

class B23
{
    static void Main(string[] args)
    {
        double sMin, sBruto, sLiquido, hTrabalhadas, coeficiente, imp, grat, auxAlimentacao;
        char turno, categoria;
        string classificacao;

        sMin = double.Parse(Console.ReadLine());
        turno = char.Parse(Console.ReadLine());
        categoria = char.Parse(Console.ReadLine());
        hTrabalhadas = double.Parse(Console.ReadLine());

        switch (turno)
        {
            case 'M':
                coeficiente = sMin * 0.1;
                break;

            case 'V':
                coeficiente = sMin * 0.15;
                break;

            case 'N':
                coeficiente = sMin * 0.12;
                break;

            default:
                coeficiente = 0;
                break;
        }

        sBruto = hTrabalhadas * coeficiente;

        switch (categoria)
        {
            case 'O':
                imp = (sBruto >= 300) ? sBruto * 0.05 : sBruto * 0.03;
                break;

            case 'G':
                imp = (sBruto >= 400) ? sBruto * 0.06 : sBruto * 0.04;
                break;

            default:
                imp = 0;
                break;
        }

        if (turno == 'N' && hTrabalhadas > 80)
        {
            grat = 50;
        }
        else
        {
            grat = 30;
        }

        if (categoria == 'O' || coeficiente <= 25)
        {
            auxAlimentacao = sBruto / 3;
        }
        else
        {
            auxAlimentacao = sBruto / 2;
        }

        sLiquido = sBruto - imp + grat + auxAlimentacao;

        if (sLiquido < 350)
        {
            classificacao = "Mal remunerado";
        }
        else if (sLiquido >= 350 && sLiquido <= 600)
        {
            classificacao = "Normal";
        }
        else
        {
            classificacao = "Bem remunerado";
        }

        Console.WriteLine($"{coeficiente:C}");
        Console.WriteLine($"{sBruto:C}");
        Console.WriteLine($"{imp:C}");
        Console.WriteLine($"{grat:C}");
        Console.WriteLine($"{auxAlimentacao:C}");
        Console.WriteLine($"{sLiquido:C}");
        Console.WriteLine(classificacao);
    }
}