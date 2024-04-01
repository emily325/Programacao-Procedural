using System;

class Program
{
    static void Main(string[] args)
    {
        int tamanho = 10;
        int[] num = new int[tamanho];
        int contador = 0;

        while(contador < tamanho)
        {
            int valordigitado = int.Parse(Console.ReadLine());
            if(valordigitado > 9 &&  valordigitado < 51)
            {
                num[contador] = valordigitado;
                contador++;
                
            }
        }
        System.Console.WriteLine();

        for (int i = 0; i < tamanho; i++)
        {
            System.Console.WriteLine(num[i]);
        }

    }
}