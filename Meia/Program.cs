using System;

namespace Meia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua Idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade<18 || idade>=60){
                Console.WriteLine("Voce tem Direito a Meia-Entrada");
            }else{
                Console.WriteLine("Você não tem Direito a Meia-Entrada");
            }
        }
    }
}
