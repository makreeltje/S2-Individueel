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
        public List<Row> _rows = new List<Row>();


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
                Stack newStack = new Stack(i, id);
                row.stacks.Add(newStack);
            }
        }

        public int FindLowestStack(int rowId)
        {
            int stackLowestWeight = _rows[rowId].stacks.Min(w => w.StackWeight);
            int stackId = _rows[rowId].stacks.Find(w => w.StackWeight == stackLowestWeight).Id;

            return stackId;
        }

        public bool AddCooledContainersToStack(int rowId, int stackId, int shipWidth)
        {
            int stack = stackId;
            if (!AddValuableCooledContainersToStack(rowId, stack, shipWidth))
                return false;

            foreach (var item in _containerCooled)
            {
                if (!_rows[rowId].stacks[stack].CalculateWeightOnTopOfLowestContainer(item))
                    return false;
                if (item.Added)
                    continue;

                _rows[rowId].stacks[stack].AddContainer(item);
                item.Added = true;
                stack = FindLowestStack(rowId);
            }
            return true;
        }

        private bool AddValuableCooledContainersToStack(int rowId, int stackId, int shipWidth)
        {
            int stack = stackId;
            if (_containerValuableCooled.Count <= 0)
                return true;
            if (_containerValuableCooled.Count > shipWidth)
                return false;
            foreach (var item in _containerValuableCooled)
            {
                if (item.Added)
                    continue;
                _rows[rowId].stacks[stack].AddContainer(item);
                item.Added = true;
                stack = FindLowestStack(rowId);
            }
            return true;
        }

        public bool AddNormalContainersToStack(int rowId, int stackId, int shipWidth, int shipLength)
        {
            int stack = stackId;
            if (!AddValuableContainersToStack(rowId, stack, shipWidth, shipLength))
                return false;

            foreach (var item in _containerNormal)
            {
                if (!_rows[rowId].stacks[stack].CalculateWeightOnTopOfLowestContainer(item))
                    return false;
                if (item.Added)
                    continue;

                _rows[rowId].stacks[stack].AddContainer(item);
                item.Added = true;
                stack = FindLowestStack(rowId);
            }
            return true;
        }

        private bool AddValuableContainersToStack(int rowId, int stackId, int shipWidth, int shipLength)
        {
            int stack = stackId;
            if (_containerValuableCooled.Count <= 0)
                return true;
            if (_containerValuableCooled.Count > (shipWidth * shipLength) - shipWidth)
                return false;
            foreach (var item in _containerValuable)
            {
                if (!_rows[rowId].stacks[stack].CalculateIfContainerHasBeenAdded())
                    return false;
                if (item.Added)
                    continue;
                _rows[rowId].stacks[stack].AddContainer(item);
                item.Added = true;
                stack = FindLowestStack(rowId);
            }
            return true;
        }

        public void ReverseStacks()
        {
            foreach (var row in _rows)
            {
                foreach (var stack in row.stacks)
                {
                    stack.containers.Reverse();
                }
            }
        }

        public void ClearStacks()
        {
            foreach (var row in _rows)
            {
                foreach (var stack in row.stacks)
                {
                    stack.containers.Clear();
                }
            }
        }

        public string BuildVisualizer(int shipWidth, int shipLength)
        {
            string shipDimensions = $"?length={shipLength}&width={shipWidth}";
            string shipContainerTypes = "&stacks=";
            string shipContainerWeights = "&weights=";
            StringBuilder sb;

            foreach (var row in _rows)
            {
                foreach (var stack in row.stacks)
                {
                    foreach (var container in stack.containers)
                    {
                        shipContainerTypes += (int)container.Category + "-";
                    }

                    shipContainerTypes += "/";
                }
            }
            foreach (var row in _rows)
            {
                foreach (var stack in row.stacks)
                {
                    foreach (var container in stack.containers)
                    {
                        shipContainerWeights += container.Weight + "-";
                    }

                    shipContainerWeights += ",";
                }

                shipContainerWeights += "/";
            }

            return $"{shipDimensions}{shipContainerTypes}{shipContainerWeights}";
        }
    }
}
