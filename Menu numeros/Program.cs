using System;

namespace Menu_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Menu de Opçoes");
            Console.WriteLine("Escolha uma das Opções");

            Console.WriteLine("(a) (Soma de 2 números)");  
            Console.WriteLine("(b) (Subtração do Primeiro pelo Segundo)");
            Console.WriteLine("(c) (Subtração do Segundo pelo Primeiro)");
            Console.WriteLine("(d) (Multiplicaçã dos Primeiro pelo Segundo)");
            Console.WriteLine("(e) (Divisão do Primeiro pelo Segundo)");
            Console.WriteLine("(f) (Divisão do Segundo pelo Primeiro)");

            string resposta = Console.ReadLine();
            
            switch(resposta){

                case "a":
                    float contaA = n1 + n2;
                    Console.WriteLine($"resultado da soma é :{contaA}");
                break;

                case "b":
                    float contaB = n1 - n2;
                    Console.WriteLine($"resultado  da subtração é :{contaB}");
                break;

                case "c":
                    float contaC = n2 - n1;
                    Console.WriteLine($"resultado da subtração é :{contaC}");
                break;

                case "d":
                    float contaD = n1 * n2;
                    Console.WriteLine($"resultado da multiplicação é :{contaD}");
                break;

                case "e":
                    float contaE = n1/n2;
                    if(n1 == 0 || n2 == 0){
                        Console.WriteLine("Não é possivel fazer divisão com zero.Digite outro número");
                    }else{
                        Console.WriteLine($"resultado da divisão é :{contaE}");
                    }
                    
                break;

                case "f":
                    float contaF = n2/n1;
                    if(n1 == 0 || n2 == 0){
                        Console.WriteLine("Não é possivel fazer divisão com zero.Digite outro número");
                    }else{
                        Console.WriteLine($"resultado da divisão é :{contaF}");
                    }
                        
                break;
            }
        }
    }
}
