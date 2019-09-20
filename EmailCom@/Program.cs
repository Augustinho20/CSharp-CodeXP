using System;

namespace EmailCom_
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;

            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();

            int i = 0;
            bool flag = false;

            while(i < email.Length){
                if(email[i] == '@'){
                    flag = true;
                    Console.WriteLine("Logado com Sucesso!");
                }
                i++;
            }

            if(flag == false){
                Console.WriteLine("E-mail Invalido");

            }else{
                Console.WriteLine("E-Mail Valido");
            }
        }
    }
}
