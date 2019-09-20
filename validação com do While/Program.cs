using System;

namespace validação_com_do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com DO WHILE");
            
            string nome;

            do
            {
                Console.WriteLine("Digite seu Nome");
                nome = Console.ReadLine();
                
            }while(nome.Length <= 1);

            string senha;
            do{
                Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();

            }while(senha.Length <= 6);
        }
    }
}
