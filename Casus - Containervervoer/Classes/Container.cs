using System.Collections.Generic;

namespace Classes
{
    public class Container
    {
        public enum Categories
        {
            None = 0,
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
