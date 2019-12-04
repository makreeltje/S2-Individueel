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
        private List<Row> _rows = new List<Row>();
        private List<Stack> _stacks = new List<Stack>();

        private void SortContainerByCategory(IEnumerable<Container> containers)
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

        private void SortContainerLists()
        {
            _containerCooled = _containerCooled.OrderByDescending(x => x.Weight).ToList();
            _containerValuableCooled = _containerValuableCooled.OrderByDescending(x => x.Weight).ToList();
            _containerNormal = _containerNormal.OrderByDescending(x => x.Weight).ToList();
            _containerValuable = _containerValuable.OrderByDescending(x => x.Weight).ToList();
        }

        private void CreateRows(int shipLength, int shipWidth)
        {
            for (int i = 1; i < shipLength; i++)
            {
                Row newRow = new Row(i);
                _rows.Add(newRow);
                CreateStacks(i, newRow, shipWidth);
            }
        }

        private void CreateStacks(int id, Row row, int shipWidth)
        {
            for (int i = 1; i <= shipWidth; i++)
            {
                Stack newStack = new Stack(i, id );
                row.stacks.Add(newStack);
            }
        }

        private void FindLowestStack(int rowId, Row row)
        {
            foreach (var VARIABLE in COLLECTION)
            {
                
            }

            int stackId = _rows[rowId].stacks.Min(w => w.StackWeight);
        }
    }
}
