using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Casus___Containervervoer
{
    internal class Stack
    {
        public int Id { get; set; }
        public int RowId { get; set; }
        public int MaxWeightOnTopOfLowestContainer { get; set; }
        public int StackWeight { get; set; }
        List<Container> containers = new List<Container>();

        public Stack(int stackId, int rowId)
        {
            Id = stackId;
            RowId = rowId;
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
            if (StackWeight + item.Weight > MaxWeightOnTopOfLowestContainer)
                return false;
            return true;
        }
    }
}
