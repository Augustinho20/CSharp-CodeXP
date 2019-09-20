using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número da tabuada");
            int tabuada = int.Parse(Console.ReadLine());

            int contador = 0;

            while(contador <=10){
                int resultado = tabuada * contador;
                Console.WriteLine($"{tabuada}X{contador} é: {resultado}");
                contador++;
            }
        }
    }
}
