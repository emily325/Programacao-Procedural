using System;

class Program
{
  static void Main(string[] args)
  { 
    int somatorio = 0;
    do
    {
      int numero = int.Parse(Console.ReadLine());
      if(numero%2==1)
      {
        somatorio+=numero;
      }
      else if(numero < 0)
      {
        break;
      }
    }
    while(true);
    
      System.Console.WriteLine("o somatorio de impares eh " + somatorio);
  }     
}
