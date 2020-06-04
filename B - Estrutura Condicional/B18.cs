/* B18
 * Dados três valores X, Y e Z, verifique se eles podem ser os comprimentos dos lados de um triângulo e,
 * se forem, verifique se é um triângulo equilátero, isósceles ou escaleno. Se eles não formarem um triângulo,
 * escreva uma mensagem. Considere que:
 * o comprimento de cada lado de um triângulo é menor que a soma dos outros dois lados;
 * chama-se equilátero o triângulo que tem três lados iguais;
 * denomina-se isósceles o triângulo que tem o comprimento de dois lados iguais;
 * recebe o nome de escaleno o triângulo que tem os três lados diferentes.
 */

using System;

class B18
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());

        if (x >= y + z || y >= x + z || z >= x + y)
        {
            Console.WriteLine("As medidas informadas não formam um triângulo.");
        }
        else if (x == y && x == z)
        {
            Console.WriteLine("Triângulo equilátero.");
        }
        else if (x == y || x == z || y == z)
        {
            Console.WriteLine("Triângulo isósceles.");
        }
        else if (x != y && x != z && y != z)
        {
            Console.WriteLine("Triângulo escaleno.");
        }
    }
}