using System;

namespace Agencia_De_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo!");

            string[] nome = new string[2];
            string[] origem = new string[2];
            string[] destino = new string[2];
            DateTime[] data = new DateTime[2];

            int opcao = 0, i = 0;

            do
            {
                Console.WriteLine("Selecione uma Opção");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Listar Passagens");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        Console.WriteLine("Vanmos Cadastrar Agora");
                        string resposta;
                        do{
                            if(i <2){
                            Console.WriteLine("Digite o nome do passageiro");
                            nome [i] = Console.ReadLine();

                            Console.WriteLine("Digite a Origem");
                            origem[i] = Console.ReadLine();

                            Console.WriteLine("Digite o Destino");
                            destino[i] = Console.ReadLine();

                            Console.WriteLine("Digite a Data do Vôo");
                            data[i] = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Você deseja cadastrar mais um? S/N");
                            resposta = Console.ReadLine();
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Número de Cadastros Excedidos");
                        break;
                        }

                        } while(resposta == "S");
                        break;
                        case 2:
                            Console.WriteLine("Listando os Passagens");
                            int j = 0;
                            while(j < 2)
                            {
                                Console.WriteLine($"Passageiro {nome[j]}, origem: {origem[j]}");
                                j++;
                            }

                        break;
                        case 0:
                            Console.WriteLine("Obrigado por usar nosso sistema!");
                        break;
                        default:
                            Console.WriteLine("Opção inválida");
                        break;
                
                    }//fim switch
                }while (opcao != 0);
   
        }
    }
}
