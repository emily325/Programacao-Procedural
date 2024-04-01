using System;
using System.Collections;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
      int numeros = 3;
      int[,] num  = new int[numeros,numeros];

      for (int linha = 0; linha < numeros; linha++)
      {
        for (int coluna = 0; coluna < numeros; coluna++)
        {
           int numerodigitado = int.Parse(Console.ReadLine());
           if(linha + coluna == 2)
           {
             num[linha, coluna] = numerodigitado *2;
           }

           else
           {
             num[linha, coluna] = numerodigitado;
           }
        }
      }

      for (int linha = 0; linha < numeros; linha++)
      {
        for (int coluna = 0; coluna < numeros; coluna++)
        {
           System.Console.Write(num[linha, coluna] + "|");
        }
        System.Console.WriteLine();
      }

      
    }
}    