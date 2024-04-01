using System;
using System.Runtime.InteropServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        int tamanho = 4;
        int[,] numeros = new int[tamanho, tamanho];
        int soma = 0;

        for (int linha = 0; linha < tamanho; linha++)
        {
            for (int coluna = 0; coluna < tamanho; coluna++)
            {
                numeros[linha, coluna] = int.Parse(Console.ReadLine());
                 soma+= numeros[linha, coluna];
            }
        }
        int digitoUsurio = int.Parse(Console.ReadLine());

        System.Console.WriteLine();
       
             if(digitoUsurio == 1 )
             {          
                for (int linha = 0; linha < tamanho; linha++)
                {
                    for (int coluna = 0; coluna < tamanho; coluna++)
                    {  
                      Console.WriteLine(numeros[linha, coluna]);
                    }
                }
             }   
             else if (digitoUsurio == 2 )
             {
               System.Console.WriteLine(soma);
             }

             else if (digitoUsurio == 3)
             {
                int somar = 0;
                for (int linha = 0; linha < tamanho; linha++)
                {
                    for(int coluna = 0; coluna < tamanho; coluna++)
                    if(linha == 2)
                    {
                      somar+= numeros[linha, coluna];
                    }
                }
                Console.WriteLine(somar);    
             }

             else if(digitoUsurio == 4)
             {
               int somatorio = 0;

                for (int linha = 0; linha < tamanho; linha++)
                {
                  for (int coluna = 0; coluna < tamanho; coluna++)
                  { 
                    if(linha == coluna)
                    {
                      somatorio+= numeros[linha, coluna];
                    }
                  }
                }
                System.Console.WriteLine(somatorio);
             }

             else if(digitoUsurio == 5)
             {
               int somatorio = 0;
               for (int linha = 0; linha < tamanho; linha++)
               {
                for (int coluna = 0; coluna < tamanho; coluna++)
                {
                   if(linha == 1 && coluna % 2 == 0)
                  {
                    somatorio+= numeros[linha, coluna];
                  }
                } 
               }
               System.Console.WriteLine(somatorio);
             }
        
    }
}
