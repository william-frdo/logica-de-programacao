/* A21
 * Uma pessoa deseja pregar um quadro em uma parede. Faça um programa
 * para calcular e mostrar a que distância a escada deve estar da parede.
 * A pessoa deve fornecer o tamanho da escada e a altura em que deseja
 * pregar o quadro. Lembre-se de que o tamanho da escada deve ser maior
 * que a altura que se deseja alcançar.
 * 
 * X – Altura em que deseja pregar o quadro
 * Y – Distância em que deverá ficar a escada
 * Z – Tamanho da escada
 */

using System;

class A21
{
    public static void Main(string[] args)
    {
        double x, y, z;

        z = double.Parse(Console.ReadLine());
        x = double.Parse(Console.ReadLine());

        y = Math.Pow(z, 2) - Math.Pow(x, 2);
        y = Math.Sqrt(y);

        Console.WriteLine(y.ToString("F2"));
    }
}