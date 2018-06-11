using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Schip
    {
        public int MaxGewicht { get; set; }
        public int MinGewicht { get; set; }
        public int HuidigGewicht { get; set; }
        public double Balans { get; set; }
        public List<Plaats> Plaatsen { get; set; }

        public Schip(int maxGewicht, int minGewicht, int huidigGewicht, double balans, List<Plaats> plaatsen)
        {
            MaxGewicht = maxGewicht;
            MinGewicht = minGewicht;
            HuidigGewicht = huidigGewicht;
            Balans = balans;
            Plaatsen = plaatsen;
        }

        public static int BerekenMinGewicht(int maxGewicht)
        {
            int minGewicht = maxGewicht / 2;
            return minGewicht;
        }
    }
}
