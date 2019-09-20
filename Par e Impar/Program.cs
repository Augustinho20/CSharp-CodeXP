using System;

namespace Par_e_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primerio número");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse (Console.ReadLine());

            if(n1 % 2 == 0){
                Console.WriteLine($"{n1} é par");

            }else{

                Console.WriteLine($"{n1} é impar");
            }

            if(n2 % 2 == 0){

                Console.WriteLine($"{n2} é par");
            }else{

                Console.WriteLine($"{n2} é impar");
            }

            if(n1 > n2){
                Console.WriteLine($"{n1} é maior");
            }else{
                Console.WriteLine($"{n2} é maior");
            }


        }
    }
}
