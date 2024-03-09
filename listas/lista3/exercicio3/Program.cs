using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {

        const string nomeusuario = "admin";
        const string senha = "123senha";
        int contador = 0;
        const int tentativas = 3;

        do
        { 
          System.Console.WriteLine("digite o nome de usuario");
          string entradausuario = Console.ReadLine();


          System.Console.WriteLine("digite sua senha");
          string entradasenha = Console.ReadLine();

          if(entradausuario == nomeusuario && entradasenha == senha)
          {
            System.Console.WriteLine("login realizado com sucesso!");
            break;
          }

          else
          {
            contador++;
          }
        
        }
        while (contador<tentativas);
        

        if(contador==tentativas)
        {
        System.Console.WriteLine("sua conta foi bloqueada");
        }

  

    }
}
