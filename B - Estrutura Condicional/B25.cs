/* B25
 * Faça um programa que receba a medida de um ângulo em graus. calcule e mostre o quadrante em
 * que se localiza esse ângulo. considere os quadrantes da trigonometria e, para ângulos maiores
 * que 360º ou menores que −360º, reduzi-los, mostrando também o número de voltas e o sentido da
 * volta (horário ou anti-horário).
 */

using System;

class B25
{
    static void Main(string[] args)
    {
        double voltas, graus;

        graus = double.Parse(Console.ReadLine());

        if (graus > 360 || graus < -360)
        {
            voltas = (int)(graus / 360);
            graus = graus / 360 - voltas;
        }
        else
        {
            voltas = 0;
        }

        if (graus == 0 || graus == 90 || graus == 180 || graus == 270 || graus == 360
            || graus == -90 || graus == -180 || graus == -270 || graus == -360)
        {
            Console.WriteLine("Está em cima de algum dos eixos");
        }

        if (graus > 0 && graus < 90 || graus < -270 && graus > -360)
        {
            Console.WriteLine("1º Quadrante");
        }

        if (graus > 90 && graus < 180 || graus < -180 && graus > -270)
        {
            Console.WriteLine("2º Quadrante");
        }

        if (graus > 180 && graus < 270 || graus < -90 && graus > -180)
        {
            Console.WriteLine("3º Quadrante");
        }

        if (graus > 270 && graus < 360 || graus < 0 && graus > -90)
        {
            Console.WriteLine("4º Quadrante");
        }

        Console.Write($"{voltas}, volta(s) no sentido ");

        if (graus < 0)
        {
            Console.Write("horário");
        }
        else
        {
            Console.Write("anti-horário");
        }
    }
}