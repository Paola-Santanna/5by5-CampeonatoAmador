using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campeonato_Amador
{
    internal class Jogo
    {
        DateOnly dataJogo { get; set; }
        int TotalGolsTimeM { get; set; }
        int TotalGollsTimeV { get; set; }
        string Resultado { get; set; }
        int ID_TimeM { get; set; }
        int ID_TimeV { get; set; }

        public Jogo()
        {
            
        }
        public Jogo(DateOnly dataJ, int totalGols_M, int totalGolls_V, int id_timeM, int id_timeV)
        {
            this.dataJogo = dataJ;
            TotalGolsTimeM = totalGols_M;
            TotalGollsTimeV = totalGolls_V;
            Resultado = " ";
            ID_TimeM = id_timeM;
            ID_TimeV = id_timeV;
        }
    }
}
