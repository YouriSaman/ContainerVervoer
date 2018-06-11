using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerVervoer
{
    public class Plaats
    {
        public List<Container> containers { get; set; }
        public int Gewicht { get; set; }

        public Plaats()
        {
            containers = new List<Container>();
        }
    }
}
