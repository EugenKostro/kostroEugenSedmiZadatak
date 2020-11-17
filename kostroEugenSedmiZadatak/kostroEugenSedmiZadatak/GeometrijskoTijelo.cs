using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenSedmiZadatak
{
    class GeometrijskoTijelo
    {
        double Volumen;
        double Oplosje;
        static int BrojacTijela;
        public GeometrijskoTijelo()
        {
            BrojacTijela++;
        }
        public override string ToString()
        {
            string vrijednost = "vrijednost je " + BrojacTijela;
            return vrijednost;
        }
            
    }
}
