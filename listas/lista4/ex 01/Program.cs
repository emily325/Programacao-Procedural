using System;

class Program
{
    static void Main(string[] args)
    {
        const int valorMaximo = 10;

        for(int fatorum = 1; fatorum <= valorMaximo; fatorum ++)
        {
            for(int fatordois = 1; fatordois <= valorMaximo; fatordois++)
            {
              System.Console.WriteLine($"{fatorum} x {fatordois} = {fatorum*fatordois}");
            }
            System.Console.WriteLine();
        }
    }
}
