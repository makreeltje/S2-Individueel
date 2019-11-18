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
            Valuable,
            Cooled,
            Standard
        }

        public Categories Category;
        public int Weight { get; set; }

        public Container(Categories cat, int weight)
        {
            Category = cat;
            Weight = weight;
        }

        public string CheckWeightContainer(int weight)
        {
            if (weight < 4000)
            {

                return $"Sorry but the weight of the container you're trying to add is too low. The weight needs to be between 4 and 30 tons. The current weight of the container is {weight / 1000} tons. ";
            }
            else
            {
                return $"Sorry but the weight of the container you're trying to add is too high. The weight needs to be between 4 and 30 tons. The current weight of the container is {weight / 1000} tons. ";
            }
        }

        public bool CheckTotalWeightContainer(int shipWeight, List<Container> containers)
        {
            int totalWeight = 0;
            foreach (var item in containers)
            {
                totalWeight += item.Weight;
            }

            if (totalWeight > shipWeight)
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
