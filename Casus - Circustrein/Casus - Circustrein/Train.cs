using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein
{
    internal class Train
    {
        public List<Wagon> Wagons = new List<Wagon>();

        public Wagon AddAnimalToNeWagon(Animal animal)
        {
            Wagon newWagon = new Wagon();
            newWagon.TryAddAnimal(animal);
            Wagons.Add(newWagon);
            return newWagon;
        }

        public List<Animal> SortAnimals(List<Animal> unorderedAnimals)
        {
            return unorderedAnimals.OrderByDescending(Animal => Animal.Carnivore)
                .ThenByDescending(Animal => (int) Animal.Size).ToList();
        }

        public void FillWagon(List<Animal> allAnimals)
        {
            allAnimals = SortAnimals(allAnimals);

            foreach (Animal currentAnimal in allAnimals)
            {
                if (currentAnimal.Carnivore)
                {
                    AddAnimalToNeWagon(currentAnimal);
                }
                else
                {
                    bool animalAdded = false;

                    foreach (Wagon currentWagon in Wagons)
                    {
                        animalAdded = currentWagon.TryAddAnimal(currentAnimal);
                        if (animalAdded) break;
                    }

                    if (!animalAdded)
                    {
                        AddAnimalToNeWagon(currentAnimal);
                    }
                }
            }
        }
    }
}
