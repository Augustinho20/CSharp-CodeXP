using System;

namespace Calculo_de_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App calculo de media e faltas");
            Console.WriteLine("Bem vindo a escola SENAI de Infomatica");

            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            //Processamento
            double media = (nota1+nota2)/2;

            if(media>= 50 && faltas<= 30){
               //Resultado verdadeiro
                Console.WriteLine("Parabéns voce foi Aprovado");
            }else{
                    //Resultado falso
                    Console.WriteLine("Infelizmente voce foi Reprovado");
               } 
        }
    }
}
