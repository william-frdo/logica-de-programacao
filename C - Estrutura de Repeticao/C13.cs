/* C13
   Foi feita uma pesquisa para determinar o índice de mortalidade infantil em certo período.
   Faça um programa que:
   leia o número de crianças nascidas no período;
   identifique o sexo (M ou F) e o tempo de vida de cada criança nascida.
   O programa deve calcular e mostrar:
   a percentagem de crianças do sexo feminino mortas no período;
   a percentagem de crianças do sexo masculino mortas no período;
   a percentagem de crianças que viveram 24 meses ou menos no período.
*/

using System;

class C13
{
    static void Main(string[] args)
    {
        int nCriancas, tempDeVida;
        double percFeme = 0, percMasc = 0, percMenorQue24Meses = 0;
        char sexo;

        Console.Write("Informe a quantidade de crianças: ");
        nCriancas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nCriancas; i++)
        {
            Console.Write($"Sexo da {i}ª criança: ");
            sexo = char.Parse(Console.ReadLine());
            Console.Write("Tempo de vida em meses: ");
            tempDeVida = int.Parse(Console.ReadLine());

            if (sexo == 'M')
            {
                percMasc++;
            }
            else
            {
                percFeme++;
            }

            if (tempDeVida <= 24)
            {
                percMenorQue24Meses++;
            }
        }

        percMasc = percMasc * 100 / nCriancas;
        percFeme = percFeme * 100 / nCriancas;
        percMenorQue24Meses = percMenorQue24Meses * 100 / nCriancas;

        Console.WriteLine($"Porcentagem de meninos mortos: {percMasc}%");
        Console.WriteLine($"Porcentagem de meninas mortas: {percFeme}%");
        Console.WriteLine($"Pocentagem de crianças que viveram 24 meses ou menos: {percMenorQue24Meses}%");
    }
}