using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class Stack
    {
        public int Id { get; set; }
        public int MaxWeightOnTopOfLowestContainer { get; set; }
        public int StackWeight { get; set; }
        public List<Container> containers = new List<Container>();

        public Stack(int stackId, int rowId)
        {
            Id = stackId;
            MaxWeightOnTopOfLowestContainer = 120;
            StackWeight = 0;
        }

        public bool AddContainer(Container container)
        {
            containers.Add(container);
            StackWeight += container.Weight;
            
            return true;
        }

        public bool CalculateWeightOnTopOfLowestContainer(Container item)
        {
            var lastItem = containers.Last();
            if (StackWeight + item.Weight - lastItem.Weight > MaxWeightOnTopOfLowestContainer)
                return false;
            return true;
        }
    }
}
