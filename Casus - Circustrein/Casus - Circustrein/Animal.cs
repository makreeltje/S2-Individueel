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
        private enum category
        { 
            small = 1,
            medium = 3,
            big = 5,
            extrabig = 10
        }

         
        public int Size { get; set; }
        private enum diet
        {
            carnivore,
            herbivore
        }

        public int Eating { get; set; }
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public bool AddedToCart { get; set; }

        public static List<Animal> list = new List<Animal>();

        private Dictionary<int, category> Woordenboek = new Dictionary<int, category>()
        {
            {1,category.small},
            {2,category.medium },
            {3,category.big },
            {4,category.extrabig }
        };

        public Animal(string _name, int _size, int _diet, bool _addedToCart)
        {
            if (String.IsNullOrEmpty((_name)) )
            {
                Name = "N/A";
            }
            else
            {
                Name = _name;
            }

            var iets = (int)Woordenboek[_size];

            //if (_type == 1)
            //{
            //    size = (int)category.small;
            //}
            //else if (_type == 2)
            //{
            //    size = (int)category.medium;
            //}
            //else
            //{
            //    size = (int)category.big;
            //}

            if (_diet == 1)
            {
                Eating = (int) diet.carnivore;
            }
            else
            {
                Eating = (int) diet.herbivore;
            }

            _addedToCart = false;
        }

    }
}
