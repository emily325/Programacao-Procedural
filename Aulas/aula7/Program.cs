using System;

class Program 
{
        static void Main(string[] args)
    { 
        System.Console.WriteLine("digite a tabuada que deseja");
        int valorrecebido = int.Parse(Console.ReadLine());
        for (int contador = 1; contador<=10; contador++ )
        {
            System.Console.WriteLine(valorrecebido * contador );
        }
        
    } 
}

