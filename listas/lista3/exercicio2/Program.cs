using System;

class Program
{
    static void Main(string[] args)
    {
        const int fretegratis = 150;
        int itens = 1;
        double precototal = 0;
    
        System.Console.WriteLine("insira a quantidade de itens que voce comprou");
        int quantidadedeitens = int.Parse(Console.ReadLine());

        while(itens<= quantidadedeitens)
        {
          System.Console.WriteLine("insira o preco do produto");
          double preco = double.Parse(Console.ReadLine());
          precototal+= preco;
          itens++;
            
        }
          if(precototal>= fretegratis)
          {
            System.Console.WriteLine("parabens! voce ganhou frete gratis em sua compra de valor" +" "+ precototal);
          }
        
        

        
    }
}

