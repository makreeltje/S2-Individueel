using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Containervervoer
{
    public class Container
    {
        public enum Categories
        {
            Normal = 1,
            Valuable = 2,
            Cooled = 3,
            ValuableCooled = 4
        }

        public Categories Category;
        public int Weight { get; set; }
        public bool Added { get; set; }

        public Container(Categories cat, int weight)
        {
            Category = cat;
            Weight = weight;
        }

        public bool CheckWeightContainer(int weight)
        {
            if (weight < 4 || weight > 30)
            {
                return true;
            }
            return false;
        }

        public bool CheckTotalWeightContainer(int shipMinWeight, int shipMaxWeight, List<Container> containers)
        {
            int totalWeight = 0;
            foreach (var item in containers)
            {
                totalWeight += item.Weight;
            }

            if (totalWeight > shipMaxWeight || totalWeight < shipMinWeight)
            {
                return false;
            }
            return true;

        }

        

        public override string ToString()
        {
            return $"Weight: {Weight}, Caterogy: {Category}";
        }
    }
}
