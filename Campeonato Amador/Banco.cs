using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato_Amador
{
    internal class Banco
    {
        string Conexao = "string de conexão";
        Banco conectarBD = new Banco();

        public Banco()
        {

        }

        SqlConnection SqlConnection { get; set; }
        public string Caminho()
        {
            return Conexao;
        }

        public void IniciarConexaoBD()
        {
            SqlConnection conexaosql = new SqlConnection(conectarBD.Conexao);
            conexaosql.Open();
        }

        public void EncerrarConexaoBD()
        {
            SqlConnection conexaosql = new SqlConnection(conectarBD.Conexao);
            conexaosql.Close();
        }
    }
}
