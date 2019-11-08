using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Containervervoer
{
    public class Ship
    {
        public int Weight { get; set; }
        public int MaxWeight { get; set; }
        public int MinWeight { get; set; }
        public int Balance { get; set; }
        public int WeightLeft { get; set; }
        public int WeightRight { get; set; }

        public Ship(int weight)
        {
            Weight = weight;
        }
    }
    
    
}
