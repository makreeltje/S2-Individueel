using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein
{
    internal class Animal
    {
        public enum Sizes
        { 
            Small = 1,
            Medium = 3,
            Big = 5,
            None = 0
        }

        public Sizes Size;
        public bool Carnivore { get; set; }
        public string Name { get; set; }

        public Animal(Sizes size, bool carnivore, string name)
        {
            Size = size;
            Carnivore = carnivore;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Size} ({(Carnivore ? "Flesh": "Plants")})";
        }

        public string getKind()
        {
            return Carnivore ? "flesheater" : "planteater";
        }
    }
}
