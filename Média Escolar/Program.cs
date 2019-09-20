using System;

namespace Média_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de Media escolar!");

            //Entrada de Dados

            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota ");
            string valorDigitado = Console.ReadLine();//Recebe um texto 
            float nota1 = float.Parse(valorDigitado);//converte um valor

            Console.WriteLine("Digite a segunda nota");
            float nota2 = float.Parse(Console.ReadLine());

            //Processamento
            float media = (nota1+nota2)/2;
            string resultado;
            if(media>=7){
                resultado = "Aprovado";
            }else{
                resultado = "Reprovado Tenhas Boas Ferias";
            }

            Console.WriteLine($"O aluno {nome} com a media {media} está {resultado}");

        }
    }
}
