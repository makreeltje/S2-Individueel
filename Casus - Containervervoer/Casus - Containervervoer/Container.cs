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

        public bool CheckWeightContainer()
        {
            return true;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}, Caterogy: {Category}";
        }
    }
}
