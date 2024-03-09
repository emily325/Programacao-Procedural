using System;

class Program
{
    static void Main(string[] args)
    {
        const int habitantes = 3;
        int somafilhos = 0;
        double somasalarios = 0;
        double maiorsalario = 0;

        for (int i =1; i <= habitantes; i ++)
        {
            System.Console.WriteLine("digite o salario do habitante:");
            double salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("digite o numero de filhos");
            int filhos = int.Parse(Console.ReadLine());

            somasalarios += salario;
            somafilhos += filhos;

            if (salario > maiorsalario)
            {
                maiorsalario = salario;
            }
        }

        double mediasalarios = somasalarios / habitantes;
        double mediafilhos = somafilhos / habitantes;
        System.Console.WriteLine("a media do salario da populacao eh:" +" "+ mediasalarios);
        System.Console.WriteLine( "a media do numero de filhos eh" +" " +  mediafilhos);
        System.Console.WriteLine("o maior salario entre os habitantes eh" + " "+ maiorsalario);



    }
}