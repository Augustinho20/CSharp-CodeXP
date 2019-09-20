using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua Idade");
            idade = int.Parse(Console.ReadLine());

            int idademeses = idade *12;
            int idadedias = idade *365;
            int idadehoras = idade *8760;
            int idademinutos = idade *525600;

            Console.WriteLine($" A idade é {idade} anos, em meses é {idademeses} meses,em dias é {idadedias} dias,em horas {idadehoras} horas,em minutos {idademinutos} minutos. ");
            

        }
    }
}
