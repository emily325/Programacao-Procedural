using System;
class Program
{
    static void Main (string[] args) 
    
    {
        Console.WriteLine("Digite a quantidade de centavos");
 
        int totalcentavos = int.Parse(Console.ReadLine());
        int reais = totalcentavos/100;
        int resto = totalcentavos% 100;

        Console.WriteLine("o total em dinheiro é" + " " +  reais + " " + "reais e "+ resto +" "+ "centavos" );
    }
}
