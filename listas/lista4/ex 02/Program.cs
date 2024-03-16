using System;

class Program
{
    static void Main(string[] args)
    {
      do
      {
       System.Console.WriteLine("digite a altura desejada do triangulo entre 1 e 9");
       int alturatriangulo = int.Parse(Console.ReadLine());
   
       
       if(alturatriangulo<1 || alturatriangulo>9)
       {
          System.Console.WriteLine("altura invalida!");
       }
       
       else
       {
            for(int linha = 1; linha <= alturatriangulo; linha++)
            {
               for(int coluna = 1; coluna <= linha; coluna++)
               {
                  System.Console.Write($"{coluna}");
               }
               System.Console.WriteLine();
      
            
            }
            break;
       }     
      }
      while(true);   
    }
}
