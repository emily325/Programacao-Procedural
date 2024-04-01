using System;
using System.Runtime.InteropServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        int[,] numeros = new int[2,2];

        int soma = 0;
        for (int linha = 0; linha < 2; linha++)
        {
            for (int coluna = 0; coluna < 2; coluna++)
            {
                numeros[linha, coluna] = int.Parse(Console.ReadLine());
                 soma+= numeros[linha, coluna];
            }
        }
        int digitoUsurio = int.Parse(Console.ReadLine());

        System.Console.WriteLine();
       
             if(digitoUsurio == 1 )
             {          
                for (int linha = 0; linha < 2; linha++)
                {
                    for (int coluna = 0; coluna < 2; coluna++)
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
                for (int linha = 0; linha < 2; linha++)
                {
                    for(int coluna = 0; coluna < 2; coluna++)
                    if(linha == 2)
                    {
                      somar+= numeros[linha, coluna];
                    }
                }
                Console.WriteLine(somar);
                        
             }
        
    }
}
