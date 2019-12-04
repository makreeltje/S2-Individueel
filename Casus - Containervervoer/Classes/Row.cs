using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus___Containervervoer;

namespace Classes
{
    class Row
    {
        public int Id { get; set; }
        public List<Stack> stacks = new List<Stack>();
        public int TotalRows { get; set; }

        public Row(int id)
        {
            Id = id;
        }

        private void AddToStack(IEnumerable<Container> containers, int shipWidth)
        {
            //int totalContainers = containers.Count();

            //foreach (var container in containers)
            //{
            //    stack = new Stack();
            //}
        }

    }
}
