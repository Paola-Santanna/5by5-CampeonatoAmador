using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato_Amador
{
    internal class Equipe
    {
        public string Nome {  get; set; }
        public string Apelido { get; set; }
        public DateOnly DataCriacao { get; set; }
        public int Pontos { get; set; }

        public Equipe()
        {
            
        }

        public Equipe(string n, string a, DateOnly dataC)
        {
            this.Nome = n;
            this.Apelido = a;
            this.DataCriacao = dataC;
            this.Pontos = 0;
        }

        //string Parametros()
        //{
        //    string dadosEquipe;

        //    return
        //}
    }
}
