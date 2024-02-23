using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("coloque sua nota do 1° bimestre");
    double nota1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("coloque sua nota do 2° bimestre"); 
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("coloque sua nota do 3° bimestre"); 
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("coloque sua nota do 4° bimestre"); 
    double nota4 = double.Parse(Console.ReadLine());

    double media = (nota1+nota2+nota3+nota4)/ 4;
    Console.WriteLine("sua média é= " + "" + media);
  }
} 
