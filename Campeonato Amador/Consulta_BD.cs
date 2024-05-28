using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato_Amador
{
    internal class Consulta_BD
    {
        Banco BDados = new Banco();
        public Consulta_BD()
        {
            
        }

        SqlCommand cmd = new SqlCommand();

        public void PopularEquipe() 
        {
            int qtdEquipes;
            bool continuar = true;
            Console.WriteLine("Quantas equipes serao incuidas?");

            do
            {
                Console.Write("\nResposta: ");
                qtdEquipes = int.Parse(Console.ReadLine());

                if (qtdEquipes > 5)
                {
                    Console.WriteLine("\nQuantidade Invalida!\n");
                    continuar = false;
                }
                else
                {
                    if (qtdEquipes < 3)
                    {
                        Console.WriteLine("\nQuantidade Invalida!\n");
                        continuar = false;
                    }
                }
            } while (continuar != true);

            #region Insercao na Tabela Equipe
            BDados.IniciarConexaoBD(); //Inicio da conexao com o banco de dados

            for (int i = 0; i < qtdEquipes; i++)
            {
                Equipe equipe = new Equipe();
                Console.WriteLine($"--- {i+1}a Equipe ---");
                Console.Write("Nome: ");
                equipe.Nome = Console.ReadLine();
                Console.Write("Apelido: ");
                equipe.Apelido = Console.ReadLine();
                Console.Write("Data da Criacao: ");
                equipe.DataCriacao = DateOnly.Parse(Console.ReadLine());

                cmd.CommandText = "INSERT INTO EQUIPE(Nome, Apelido, Data_Criacao, Pontos) VALUES (@Nome, @Apelido, @Data_Criacao, @Pontos)"; //Comando SQL

                //Atribuindo o valor das variaveis em sql aos parametros (variaveis) definidas no c#
                SqlParameter nome = new SqlParameter("@Nome", System.Data.SqlDbType.VarChar, 50);
                SqlParameter apelido = new SqlParameter("@Apelido", System.Data.SqlDbType.VarChar, 50);
                SqlParameter dataCriacao = new SqlParameter("@Data_Criacao", System.Data.SqlDbType.Date);
                SqlParameter pontos = new SqlParameter("@Pontos", System.Data.SqlDbType.Int);

                //Fazendo GET -> Armazenamento dos dados digitados pelo usuario na variavel que sera o parametro no SQL
                nome.Value = equipe.Nome;
                apelido.Value = equipe.Apelido;
                dataCriacao.Value = equipe.DataCriacao;
                pontos.Value = equipe.Pontos;

                //Adicionando as variaveis como parametro para a populacao da tabela EQUIPE
                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(apelido);
                cmd.Parameters.Add(dataCriacao);
                cmd.Parameters.Add(pontos);

                cmd.ExecuteNonQuery();

                
            }
            BDados.EncerrarConexaoBD(); //Encerramento da conexao com o banco de dados
            #endregion
        }

        public void MostrarTabelaEquipe()
        {
            BDados.IniciarConexaoBD();

            cmd.CommandText = "SELECT ID_Equipe, Nome, Apelido, Data_Criacao, Pontos FROM Equipe";

            BDados.EncerrarConexaoBD();
        }
    }
}
