using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
      int totalnumeros = 3;
      int[,] numeros = new int[totalnumeros, totalnumeros];
      for(int i = 0; i < totalnumeros; i++)
      {
        for(int j=0; j < totalnumeros; j++)
        {
            numeros[i,j] =  int.Parse(Console.ReadLine());
        }
      }
      System.Console.WriteLine();

      int soma = 0;
       for(int i = 0; i < totalnumeros; i++)
       {
        for(int j = 0; j < totalnumeros; j++)
        {
            if(i == j)
            {
              soma += numeros[i,j];
            }
        }
       } 
      System.Console.WriteLine(soma);
    }
}
