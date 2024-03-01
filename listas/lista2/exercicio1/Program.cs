using System;

class Program
{
static void Main(string[] args)
  {
    const string nome = "admin";
    Console.WriteLine("digite seu nome de usuario");
    string nomedousuario = Console.ReadLine();

    Console.WriteLine("digite sua senha");
    string senha = Console.ReadLine();

    if (nome == nomedousuario && senha == "123senha")
    {
      Console.WriteLine("Login realizado com sucesso!");
    }
    else
    {
      Console.WriteLine("Credenciais invalidas");
    }
   
  }
}
