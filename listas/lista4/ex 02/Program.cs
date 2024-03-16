using System;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("digite a altura desejada do triangulo");
       int alturatriangulo = int.Parse(Console.ReadLine());
   
       
       if(alturatriangulo<1 || alturatriangulo>9)
       {
          System.Console.WriteLine("altura invalida insira uma altura entre 1 e 9");

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
       }     
      
    }
}
