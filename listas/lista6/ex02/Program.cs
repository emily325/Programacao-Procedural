using System;

class Program
{
    static void Main(string[] args)
    {
        int totalnomes = 10;
        string[] nomes  = new string[10];

        for(int i = 0; i < totalnomes; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        System.Console.WriteLine();

        for(int i = totalnomes - 1; i >= 0; i--)
        {
           if(i % 2 == 0)
           {
             System.Console.WriteLine(nomes[i]);
           }
        }
    }
}
