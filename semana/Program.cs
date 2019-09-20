using System;

namespace semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu ano de nacimento");
            int nacimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - nacimento;

            int semanas = idade *52;

            Console.WriteLine($"A sua idade atual é de {idade}. isso convertido em semanas é igual a {semanas} semanas");



        }
    }
}
