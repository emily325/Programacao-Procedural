using System;
using System.Runtime.InteropServices;

class Program
{
    struct Pizza()
    {
        public int id;
        public string sabor;
        public double preco;
    }
    static void Main(string[] args)
    {
       Pizza dados;
       dados.id = int.Parse(Console.ReadLine());
       dados.sabor = Console.ReadLine();
       dados.preco = double.Parse(Console.ReadLine());
       System.Console.WriteLine();
       
       System.Console.WriteLine(dados.id);
       System.Console.WriteLine(dados.sabor);
       System.Console.WriteLine(dados.preco);
    }
}
