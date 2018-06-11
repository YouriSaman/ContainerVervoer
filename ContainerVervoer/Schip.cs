using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Schip
    {
        public int MaxGewicht { get; set; }
        public int MinGewicht { get; set; }
        public int HuidigGewicht { get; set; }
        public int GewichtLinks { get; set; }
        public int GewichtRechts { get; set; }
        public double Balans { get; set; }
        public List<Plaats> Plaatsen { get; }

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

        public static Schip PlaatsContainers(List<Container> containers, Schip _schip)
        {
            List<Container> waardevolContainers = new List<Container>();
            List<Container> gekoeldContainers = new List<Container>();
            List<Container> standaardContainers = new List<Container>();

            foreach (var container in containers)
            {
                if (container.Waardevol)
                {
                    waardevolContainers.Add(container);
                }
                else if (container.Gekoeld)
                {
                    gekoeldContainers.Add(container);
                }
                else
                {
                    standaardContainers.Add(container);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (waardevolContainers.Count > 0)
                {
                    if (i != 2 && i != 3)
                    {
                        _schip.Plaatsen[i].containers.Add(waardevolContainers.First());
                        _schip.Plaatsen[i].Gewicht += waardevolContainers.First().Gewicht;
                        waardevolContainers.Remove(waardevolContainers.First());
                    }
                }
            }

            //plaatsen[1, 3, 5] zijn links en nu gevuld met de eventuele waardevolle containers die nu het gewicht voor de linkse kant zorgen
            _schip.GewichtLinks += _schip.Plaatsen[1].Gewicht + _schip.Plaatsen[3].Gewicht + _schip.Plaatsen[5].Gewicht;
            //plaatsen[0, 2, 4] zijn rechts en nu gevuld met de eventuele waardevolle containers die nu het gewicht voor de rechtse kant zorgen
            _schip.GewichtRechts += _schip.Plaatsen[0].Gewicht + _schip.Plaatsen[2].Gewicht + _schip.Plaatsen[4].Gewicht;

            //TODO checken
            if (gekoeldContainers.Count < 0)
            {
                foreach (var gekoeldContainer in gekoeldContainers)
                {
                    if (_schip.GewichtLinks > _schip.GewichtRechts)
                    {
                        _schip.Plaatsen[0].containers.Add(gekoeldContainer);
                        _schip.GewichtRechts += gekoeldContainer.Gewicht;
                    }
                    else
                    {
                        _schip.Plaatsen[1].containers.Add(gekoeldContainer);
                        _schip.GewichtLinks += gekoeldContainer.Gewicht;
                    }
                }
            }

            return _schip;
        }
    }
}
