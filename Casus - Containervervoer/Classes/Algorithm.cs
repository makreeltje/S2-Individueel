using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus___Containervervoer;

namespace Classes
{
    class Algorithm
    {

        private List<Container> _containerNormal = new List<Container>();
        private List<Container> _containerCooled = new List<Container>();
        private List<Container> _containerValuable = new List<Container>();
        private List<Container> _containerValuableCooled = new List<Container>();

        private void CheckContainerCategory(IEnumerable<Container> containers)
        {
            foreach (var container in containers)
            {
                switch (container.Category)
                {
                    case Container.Categories.Normal:
                        _containerNormal.Add(container);
                        break;
                    case Container.Categories.Cooled:
                        _containerCooled.Add(container);
                        break;
                    case Container.Categories.Valuable:
                        _containerValuable.Add(container);
                        break;
                    case Container.Categories.ValuableCooled:
                        _containerValuableCooled.Add(container);
                        break;
                }
            }
        }

        private void CreateStacks(int shipWidth)
        {
            for (int i = 0; i < shipWidth; i++)
            {
            }
        }

        private void SplitCooledContainers(IEnumerable<Container> containerCooled,
            IEnumerable<Container> containerValuableCooled)
        {
            foreach (var container in containerCooled)
            {
                
            }

        }
    }
}
