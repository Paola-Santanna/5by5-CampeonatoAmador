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
        string Conexao = "Data Source=127.0.0.1; Initial Catalog=Campeonato_Amador; User Id=sa; Password=SqlServer2019!";
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
