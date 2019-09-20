using System;

namespace Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu Nome!");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira seu Salário");
            double salario = double.Parse(Console.ReadLine());


            Console.WriteLine("Escolha um código de 1 a 5");
            Console.WriteLine("(1) - Escriturário");
            Console.WriteLine("(2) - Secretário");
            Console.WriteLine("(3) - Caixa");
            Console.WriteLine("(4) - Gerente");
            Console.WriteLine("(5) - Diretor");

            Console.WriteLine("Digite seu Código");
            int codigo = int.Parse(Console.ReadLine());
            double aumento;

            switch(codigo){
                case 1:
                    Console.WriteLine($"Seu Nome é {nome}");
                    Console.WriteLine($"Seu Salário é {salario}");
                    Console.WriteLine($"Seu Código é {codigo}");
                    Console.WriteLine("Cargo Escriturário");
                    Console.WriteLine("Seu Porcentual de aumento é 50%");
                    aumento = 0.5 * salario;
                    salario = salario + aumento;
                    Console.WriteLine($"O seu Salário com aumento é: {salario}");
                break;

                case 2:
                    Console.WriteLine($"Seu Nome é {nome}");
                    Console.WriteLine($"Seu Salário é {salario}");
                    Console.WriteLine($"Seu Código é {codigo}");
                    Console.WriteLine("Cargo Secretário");
                    Console.WriteLine("Seu Porcentual de aumento é 35%");
                    aumento = 0.5 * salario;
                    salario = salario + aumento;
                    Console.WriteLine($"O seu Salário com aumento é: {salario}");
                break;

                case 3:
                    Console.WriteLine($"Seu Nome é {nome}");
                    Console.WriteLine($"Seu Salário é {salario}");
                    Console.WriteLine($"Seu Código é {codigo}");
                    Console.WriteLine("Cargo Caixa");
                    Console.WriteLine("Seu Porcentual de aumento é 20%");
                    aumento = 0.5 * salario;
                    salario = salario + aumento;
                    Console.WriteLine($"O seu Salário com aumento é: {salario}");
                break;

                case 4:
                    Console.WriteLine($"Seu Nome é {nome}");
                    Console.WriteLine($"Seu Salário é {salario}");
                    Console.WriteLine($"Seu Código é {codigo}");
                    Console.WriteLine("Gerente");
                    Console.WriteLine("Seu Porcentual de aumento é 10%");
                    aumento = 0.5 * salario;
                    salario = salario + aumento;
                    Console.WriteLine($"O seu Salário com aumento é: {salario}");
                break;

                case 5:
                    Console.WriteLine($"Seu Nome é {nome}");
                    Console.WriteLine($"Seu Salário é {salario}");
                    Console.WriteLine($"Seu Código é {codigo}");
                    Console.WriteLine("Cargo Diretor");
                    Console.WriteLine("Seu Porcentual de aumento é 50%");
                    aumento = 0.5 * salario;
                    salario = salario + aumento;
                    Console.WriteLine($"O seu Salário com aumento é: {salario}");
                break;

                default:
                    Console.WriteLine("Digite um número de 1 a 5.");
                break;
            }

        }
    }
}
