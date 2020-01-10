using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Row
    {
        public int Id { get; set; }
        public List<Stack> stacks = new List<Stack>();

        public Row(int id)
        {
            Id = id;
        }
        public void CreateStacks(int id, Row row, int shipWidth)
        {
            for (int i = 0; i < shipWidth; i++)
            {
                Stack newStack = new Stack(i, id);
                row.stacks.Add(newStack);
            }
        }

        public int FindLowestStack()
        {
            int stackLowestWeight = stacks.Min(w => w.StackWeight);
            int stackId = stacks.Find(w => w.StackWeight == stackLowestWeight).Id;

            return stackId;
        }

        public void ClearStacks()
        {
            foreach (var stack in stacks)
            {
                stack.containers.Clear();
            }
        }

        public void ReverseStacks()
        {
            foreach (var stack in stacks)
            {
                stack.containers.Reverse();
            }
        }
    }
}
