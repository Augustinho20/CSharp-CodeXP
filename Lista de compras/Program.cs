using System;

namespace Lista_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Compras");

            string[] lista = new string[6];
            
            int contador = 0;
            while(contador < 6){
                Console.WriteLine($"Digite seu {contador+1}º produto");
                lista[contador] = Console.ReadLine();
                contador++;
                
            }
                contador = 0;
                while(contador < 6){
                    Console.WriteLine($"Seu {contador+1}º produto é {lista[contador]}");
                    contador++;
                }
        }
    }
}
