using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein_v2
{
    public class Animal
    {
        public enum Sizes
        {
            Small = 1,
            Medium = 3,
            Big = 5,
            None = 0
        }

        public enum Types
        {
            Carnivore = 0,
            Herbivore = 1
        }

        public string Name { get; set; }
        public Sizes Size;
        public Types Type;
        public Animal(string name, Types type, Sizes size)
        {
            Name = name;
            Type = type;
            Size = size;
        }
    }
}
