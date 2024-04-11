using System;

class Program
{
    struct Produto
    {
        public int id;
        public string nome;
        public double preco;
        public bool disponivelEmEstoque;
    }

    static void Main(string[] args)
    {
      Produto[] produtos = new Produto[4];

      for (int i = 0; i < produtos.Length; i++)
      {
        produtos[i].id = int.Parse(Console.ReadLine());
        produtos[i].nome = Console.ReadLine();
        produtos[i].preco = double.Parse(Console.ReadLine());
        produtos[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
      }
      System.Console.WriteLine();

      for (int i = 0; i < produtos.Length; i++)
      {
        if(produtos[i].disponivelEmEstoque)
        {
           System.Console.WriteLine( produtos[i].nome);
           System.Console.WriteLine( produtos[i].preco);
        }
      }    
    }
}
