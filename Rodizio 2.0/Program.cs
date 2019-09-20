using System;

namespace Rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saiba se é seu dia de navegar com seu Veiculo!");

            Console.WriteLine("Digite o ultimo número da placa do seu carro");
            // int final =int.Parse(Console.ReadLine());
            string placa = Console.ReadLine();

            int  caracteres = placa.Length;

            int final = int.Parse(placa.Substring(caracteres - 1));

            Console.WriteLine($"A posição 0 é: {final}");

            if(final == 0 || final == 1){
                Console.WriteLine("O seu carro pode navegar na Segunda-Feira");
            }else if(final == 2 || final == 3){
                Console.WriteLine("O seu carro pode navegar na Terça-Feira");

            }else if(final == 4 || final == 5){
                Console.WriteLine("O seu carro pode navegar na Quarta-Feira");

            }else if(final == 6 || final == 7){
                Console.WriteLine("O seu carro pode navegar na Quinta-Feira");
            }else if(final == 8 || final == 9){
                Console.WriteLine("O seu carro pode navegar na Sexta-Feira");
            }else{
                Console.WriteLine("Digite apenas o último digito");
            }
        }
    }
}