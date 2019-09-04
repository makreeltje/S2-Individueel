using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein
{
    internal class Animal
    {
        private enum category
        { 
            small = 1,
            medium = 3,
            big = 5
        }
        public int size { get; set; }
        private enum diet
        {
            carnivore,
            herbivore
        }

        public int eating { get; set; }
        public int AnimalID { get; set; }
        public string Name { get; set; }

        public Animal(int i, string name, int type, int diet)
        {
            AnimalID = i;
            if (String.IsNullOrEmpty((name)) )
            {
                Name = "N/A";
            }
            else
            {
                Name = name;
            }
            if (type == 1)
            {
                size = (int) category.small;
            }
            else if (type == 2)
            {
                size = (int) category.medium;
            }
            else
            {
                size = (int) category.big;
            }

            if (diet == 1)
            {
                eating = (int) Animal.diet.carnivore;
            }
            else
            {
                eating = (int) Animal.diet.herbivore;
            }
        }

    }
}
