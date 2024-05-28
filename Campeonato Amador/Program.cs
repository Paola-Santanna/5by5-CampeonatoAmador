using Campeonato_Amador;
using System;
using Microsoft.Data.SqlClient;

namespace Programa_Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consulta_BD consulta = new Consulta_BD();

            Console.WriteLine(">>>Campeonato Amador<<</n");
            Console.WriteLine(">>>Adicione Equipes ao Campeonato<<<");
            consulta.PopularEquipe();
            consulta.MostrarTabelaEquipe();

            #region Menu
            int Menu() 
            {
                Console.WriteLine("Digite o numero da opcao correspondente:");
                Console.WriteLine("1 -> Mostrar o campeao do campeonato");
                Console.WriteLine("2 -> Mostrar os 5 primeiros times");
                Console.WriteLine("3 -> Time que mais fez gols");
                Console.WriteLine("4 -> Time que levou mais gols");
                Console.WriteLine("5 -> Jogo que teve mais gols");
                Console.WriteLine("6 -> Maior numero de gols de cada time em um jogo");
                Console.WriteLine("0 -> SAIR");
                int resposta = int.Parse(Console.ReadLine());

                return resposta;
            }
            #endregion

            int opcaoMenu = Menu();

            do
            {
                switch (opcaoMenu)
                {
                    case 1:
                        Console.WriteLine(">>>Campeao do Campeonato<<<");
                        break;
                    case 2:
                        Console.WriteLine(">>>Classificacao Times<<<");
                        break;
                    case 3:
                        Console.WriteLine(">>>Time Que Mais Fez Gols<<<");
                        break;
                    case 4:
                        Console.WriteLine(">>>Time Que Levou Mais Gols<<<");
                        break;
                    case 5:
                        Console.WriteLine(">>>Jogo Que Teve Mais Gols<<<");
                        break;
                    case 6:
                        Console.WriteLine(">>>Maior Numero de Gols de Cada Time em um Jogo<<<");
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo...");
                    break;
                    default:
                        Console.WriteLine("\nOpcao Invalida!\n");
                        break;
                }
                opcaoMenu = Menu();

            } while (opcaoMenu != 0);

            Console.WriteLine("Pressione ENTER para encerrar...");
            Console.ReadKey();
        }
    }
}