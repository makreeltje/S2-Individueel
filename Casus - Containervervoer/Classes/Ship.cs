using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class Ship
    {
        private List<Container> _containerNormal = new List<Container>();
        private List<Container> _containerCooled = new List<Container>();
        private List<Container> _containerValuable = new List<Container>();
        private List<Container> _containerValuableCooled = new List<Container>();
        private readonly List<Row> _rows = new List<Row>();
        public int Lenght { get; }
        public int Width { get; }
        public int MaxWeight { get; }
        public int MinWeight { get; }

        public Ship(int length, int width)
        {
            Lenght = length;
            Width = width;
            MaxWeight = CalculateMaxWeight(length, width);
            MinWeight = CalculateMinWeight(length, width);

        }

        public List<Row> GetRows()
        {
            return _rows;
        }
        public List<Container> GetContainerNormalList()
        {
            return _containerNormal;
        }
        public List<Container> GetContainerCooledList()
        {
            return _containerCooled;
        }
        public List<Container> GetContainerValuableList()
        {
            return _containerValuable;
        }
        public List<Container> GetContainerValuableCooledList()
        {
            return _containerValuableCooled;
        }

        private int CalculateMaxWeight(int length, int width)
        {
            int result = length * width;
            result *= 150;
            return result;
        }

        private int CalculateMinWeight(int length, int width)
        {
            int result = length * width;
            result *= 150;
            result /= 2;
            return result;
        }
        public IEnumerable<Container> SortContainerByCategory(IEnumerable<Container> containers)
        {
            ClearLists();

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
            SortContainerLists();

            return containers;
        }

        private void ClearLists()
        {
            _containerNormal.Clear();
            _containerCooled.Clear();
            _containerValuable.Clear();
            _containerValuableCooled.Clear();
        }
        private void SortContainerLists()
        {
            _containerCooled = _containerCooled.OrderByDescending(x => x.Weight).ToList();
            _containerValuableCooled = _containerValuableCooled.OrderByDescending(x => x.Weight).ToList();
            _containerNormal = _containerNormal.OrderByDescending(x => x.Weight).ToList();
            _containerValuable = _containerValuable.OrderByDescending(x => x.Weight).ToList();
        }

        // RETURN VALUES:
        // 0 = Too many valuable cooled containers
        // 1 = Too many cooled containers
        // 3 = Calculation is done
        // 4 = Too many valuable containers
        public int AddContainerToStack(int shipWidth, int shipLength)
        {
            int stackId;
            if (_containerValuableCooled.Count <= shipWidth)
            {
                if (_containerValuable.Count <= shipWidth)
                {
                    foreach (var row in _rows)
                    {
                        if (row.Id > 0)
                            if (_containerCooled.Any(c => c.Added == false))
                                return 1;
                        foreach (var containerValCooled in _containerValuableCooled)
                        {
                            if (!containerValCooled.Added)
                            {
                                stackId = row.FindLowestStack();
                                row.stacks[stackId].AddContainer(containerValCooled);
                                containerValCooled.Added = true;
                            }
                        }

                        foreach (var containerCooled in _containerCooled)
                        {
                            if (!containerCooled.Added)
                            {
                                stackId = row.FindLowestStack();
                                if (row.stacks[stackId].CalculateWeightOnTopOfLowestContainer(containerCooled))
                                {
                                    row.stacks[stackId].AddContainer(containerCooled);
                                containerCooled.Added = true;
                                }
                            }
                        }

                        foreach (var containerValuable in _containerValuable)
                        {
                            if (!containerValuable.Added)
                            {
                                if (row.Id == shipLength - 1)
                                {
                                    stackId = row.FindLowestStack();
                                    row.stacks[stackId].AddContainer(containerValuable);
                                    containerValuable.Added = true;
                                }
                            }
                        }

                        foreach (var containerNormal in _containerNormal)
                        {
                            if (!containerNormal.Added)
                            {
                                stackId = row.FindLowestStack();
                                if (row.stacks[stackId].CalculateWeightOnTopOfLowestContainer(containerNormal))
                                {
                                    row.stacks[stackId].AddContainer(containerNormal);
                                    containerNormal.Added = true;
                                }
                            }
                        }
                    }
                }
                else
                    return 4;
            }
            else
                return 0;

            return 3;
        }
        public void CreateRows(int shipLength, int shipWidth)
        {
            for (int i = 0; i < shipLength; i++)
            {
                Row newRow = new Row(i);
                _rows.Add(newRow);
                newRow.CreateStacks(i, newRow, shipWidth);
            }
        }
        public void ReverseStacks()
        {
            foreach (var row in _rows)
            {
                row.ReverseStacks();
            }
        }
        public void ClearStacks()
        {
            foreach (var row in _rows)
            {
                row.ClearStacks();
            }
        }
        //public string BuildVisualizer(int shipWidth, int shipLength)
        //{
        //    string shipDimensions = $"?length={shipLength}&width={shipWidth}";
        //    string shipContainerTypes = "&stacks=";
        //    string shipContainerWeights = "&weights=";

        //    foreach (var row in _rows)
        //    {
        //        foreach (var stack in row.stacks)
        //        {
        //            foreach (var container in stack.containers)
        //            {
        //                shipContainerTypes += (int)container.Category + "-";
        //            }

        //            shipContainerTypes += "/";
        //        }
        //    }
        //    foreach (var row in _rows)
        //    {
        //        foreach (var stack in row.stacks)
        //        {
        //            foreach (var container in stack.containers)
        //            {
        //                shipContainerWeights += container.Weight + "-";
        //            }

        //            shipContainerWeights += ",";
        //        }

        //        shipContainerWeights += "/";
        //    }

        //    return $"{shipDimensions}{shipContainerTypes}{shipContainerWeights}";
        //}
    }
    
    
}
