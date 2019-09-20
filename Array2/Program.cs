using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetivo Efetuar o cadestro de usúario com os seguintes
            //dados Nome, Telefone e Email de 5 usúario
            Console.WriteLine("Exercício de Arrays 2");

            string[] nomes = new string[5];
            string[] telefones = new string[5];
            string[] email = new string[5];

            int contador = 0;
            while(contador <=4){
                Console.WriteLine("Digite o seu Nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu Telefone");
                telefones[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu Email");
                email[contador] = Console.ReadLine();

                contador++;
                //fim do while

                int contadorB = 0;
                while(contadorB <=4){
                    Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nomes[contadorB]} - Telefone: {telefones[contadorB]} - E-Mail:{email[contadorB]}");

                    contadorB++;
                }
            }

        }
    }
}
