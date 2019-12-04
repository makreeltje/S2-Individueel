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
        public int MaxStackWeight { get; set; }
        public int StackWeight { get; set; }
        List<Container> containers = new List<Container>();

        public Stack(int stackId, int rowId)
        {
            Id = stackId;
            RowId = rowId;
            MaxStackWeight = 150;
            StackWeight = 0;
        }
    }
}
