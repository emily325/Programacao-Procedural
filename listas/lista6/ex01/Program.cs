using System;

class Program
{
    static void Main(string[] args)
    {
        int totalNomes = 10;
        string[] nomes = new string[totalNomes];

        for(int i =0; i < totalNomes; i++)
        {
            nomes[i]  = Console.ReadLine();
        }
        System.Console.WriteLine();
        string novonome  = Console.ReadLine();

        bool temnome = false;
  

        for(int i =0; i < totalNomes; i++)
        {
           if(novonome == nomes[i])
           {
             temnome = true;
           } 
        }
        if(temnome)
        {
          System.Console.WriteLine("ACHEI");
        }
        else
        {
          System.Console.WriteLine("NAO ACHEI");
        } 
       
    }
}
