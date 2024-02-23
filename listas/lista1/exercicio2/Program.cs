using System;
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Digite a base do triângulo");
        double basetriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do triângulo");
        double altura = double.Parse(Console.ReadLine());

        double resultado = (basetriangulo*altura)/2;
        bool maiorde20 = resultado >= 20;
        Console.WriteLine("o valor do triângulo é maior que 20?"+ "" +  maiorde20);

    }
}