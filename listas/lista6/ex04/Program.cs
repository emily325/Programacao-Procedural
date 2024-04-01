using System;
using System.Collections;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
      int[,] num  = new int[3,3];

      for(int i = 0; i < num.Length; i++)
      {
        for(int j = 0; j < num.Length; j++)
        {
            num[i, j] = int.Parse(Console.ReadLine());
        }
      }

      for(int i = 0; i < num.Length; i++)
      {
        for(int j = 0; j < num.Length; j++)
        {
            
        }
      }


    }
}    