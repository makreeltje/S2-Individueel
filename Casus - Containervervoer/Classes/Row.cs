﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casus___Containervervoer;

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

    }
}
