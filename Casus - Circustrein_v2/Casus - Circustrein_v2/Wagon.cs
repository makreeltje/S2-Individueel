using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein_v2
{
    public class Wagon
    {
        Train Trains = new Train();
        public List<Animal> Animals = new List<Animal>();
        public int Space { get; set; } = 10;

        private Animal.Sizes BiggestCarnivore()
        {
            List<Animal> CarnivoreList = Animals.Where(Animal => ((int) Animal.Type == 0)).ToList();

            if (CarnivoreList.Count == 0) { return Animal.Sizes.None; }
            else { return CarnivoreList.First().Size; }
        }

        public bool AddAnimal(Animal newAnimal)
        {
            if (newAnimal.Size > BiggestCarnivore() && (int) newAnimal.Size <= Space)
            {
                Animals.Add(newAnimal);
                Space = 10 - Animals.Sum(Animal => (int) Animal.Size);
                return true;
            }
            else { return false; }
        }

        public override string ToString()
        {
            return "Wagon";
        }
    }
}
