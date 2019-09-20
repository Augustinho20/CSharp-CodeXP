using System;

namespace Salario_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salario");
            double salario = float.Parse(Console.ReadLine());

            if(salario <990){
                double acrescimo = salario*0.30;
                salario = acrescimo + salario;

                Console.WriteLine($"Valor reajustado é {salario}");
            }else{
                Console.WriteLine("Você não tem direito");

            }
        }
    }
}
