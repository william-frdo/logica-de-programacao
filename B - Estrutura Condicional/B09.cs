/* B09
 * Faça um programa que mostre a data e a hora do sistema nos seguintes
 * formatos: DD/MM/AAAA – mês por extenso e hora:minuto.
 */

using System;
using System.Globalization;

class B09
{
    static void Main(string[] args)
    {
        double hora, min;
        int DD, MM, AAAA;
        string mes = "";

        hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        String[] data = Console.ReadLine().Split("/");
        DD = int.Parse(data[0]);
        MM = int.Parse(data[1]);
        AAAA = int.Parse(data[2]);

        switch (MM)
        {
            case 01:
                mes = "Janeiro";
                break;

            case 02:
                mes = "Fevereiro";
                break;

            case 03:
                mes = "Março";
                break;

            case 04:
                mes = "Abril";
                break;

            case 05:
                mes = "Maio";
                break;

            case 06:
                mes = "Junho";
                break;

            case 07:
                mes = "Julho";
                break;

            case 08:
                mes = "Agosto";
                break;

            case 09:
                mes = "Setembro";
                break;

            case 10:
                mes = "Outubro";
                break;

            case 11:
                mes = "Novembro";
                break;

            case 12:
                mes = "Dezembro";
                break;

            default:
                break;
        }

        min = (hora - (int)hora) * 100;
        hora = (int)hora;

        Console.WriteLine($"{DD}/{mes}/{AAAA} - {hora}:{min:F0}");
    }
}