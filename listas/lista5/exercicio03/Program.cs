using System;

class Program
{
    static void Main(string[] args)
    {
      int altura = int.Parse(Console.ReadLine());
    
      int baseretangulo = int.Parse(Console.ReadLine());
      
      for(int linha = 0; linha < altura; linha++)
      {
        for(int coluna = 0; coluna < baseretangulo; coluna++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
      }
    }
}
