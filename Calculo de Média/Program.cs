using System;

namespace Calculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média dos números!");

            Console.WriteLine("Digite a 1 Nota");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2 Nota");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3 Nota");
            int n3 = int.Parse(Console.ReadLine());

            float soma = (n1+n2+n3);
            float media = soma/3;

            Console.WriteLine($"A média é de: {media}");
        }                                                           
    }
}
