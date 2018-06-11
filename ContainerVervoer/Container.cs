using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Container
    {
        public int Gewicht { get; set; }
        public bool Waardevol { get; set; }
        public bool Gekoeld { get; set; }

        public Container(int gewicht, bool waardevol, bool gekoeld)
        {
            Gewicht = gewicht;
            Waardevol = waardevol;
            Gekoeld = gekoeld;
        }

        public override string ToString()
        {
            return "Gewicht= " + Gewicht + "kg, Waardevol= " + Waardevol + ", Gekoeld= " + Gekoeld;
        }
    }
}
