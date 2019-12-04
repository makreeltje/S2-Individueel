using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus___Containervervoer;

namespace Classes
{
    public class Algorithm
    {
        public List<Container> _containerNormal = new List<Container>();
        public List<Container> _containerCooled = new List<Container>();
        public List<Container> _containerValuable = new List<Container>();
        public List<Container> _containerValuableCooled = new List<Container>();
        private List<Row> _rows = new List<Row>();


        public Algorithm()
        {
        }

        public void SortContainerByCategory(IEnumerable<Container> containers)
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

        public void SortContainerLists()
        {
            _containerCooled = _containerCooled.OrderByDescending(x => x.Weight).ToList();
            _containerValuableCooled = _containerValuableCooled.OrderByDescending(x => x.Weight).ToList();
            _containerNormal = _containerNormal.OrderByDescending(x => x.Weight).ToList();
            _containerValuable = _containerValuable.OrderByDescending(x => x.Weight).ToList();
        }

        public void CreateRows(int shipLength, int shipWidth)
        {
            for (int i = 0; i < shipLength; i++)
            {
                Row newRow = new Row(i);
                _rows.Add(newRow);
                CreateStacks(i, newRow, shipWidth);
            }
        }

        private void CreateStacks(int id, Row row, int shipWidth)
        {
            for (int i = 0; i < shipWidth; i++)
            {
                Stack newStack = new Stack(i, id );
                row.stacks.Add(newStack);
            }
        }

        public int FindLowestStack(int rowId)
        {
            int stackLowestWeight = _rows[rowId].stacks.Min(w => w.StackWeight);
            int stackId = _rows[rowId].stacks.Find(w => w.StackWeight == stackLowestWeight).Id;

            return stackId;
        }

        public bool AddCooledContainersToStack(int rowId, int stackId)
        {
            int stack = stackId;
            foreach (var item in _containerCooled)
            {
                if (!_rows[rowId].stacks[stack].CalculateWeightOnTopOfLowestContainer(item))
                    return false;
                if(item.Added)
                    continue;
                
                _rows[rowId].stacks[stack].AddContainer(item);
                item.Added = true;
                stack = FindLowestStack(rowId);
            }
            return true;
        }
    }
}
