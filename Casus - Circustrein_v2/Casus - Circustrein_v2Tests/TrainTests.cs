using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casus___Circustrein_v2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein_v2.Tests
{
    [TestClass()]
    public class TrainTests
    {
        Animal animals;
        Train trains;
        Wagon wagons;

        [TestMethod()]
        public void CreateOneAnimalTest()
        {
            List<Animal> Animals = new List<Animal>();
            Animal newAnimal = new Animal("Tijger", Animal.Types.Carnivore, Animal.Sizes.Big);
            Animals.Add(newAnimal);

            int amount = Animals.Count();

            Assert.AreEqual(1, amount);
        }

        [TestMethod()]
        public void CreateAnimalsTest()
        {
            List<Animal> Animals = new List<Animal>();
            for (int i = 0; i < 5; i++)
            {
                foreach (Animal.Types types in Enum.GetValues(typeof(Animal.Types)))
                {
                    foreach (Animal.Sizes sizes in Enum.GetValues(typeof(Animal.Sizes)))
                    {
                        if (sizes != Animal.Sizes.None)
                        {
                            Animal animal = new Animal("Animal", types, sizes);
                            Animals.Add(animal);
                        }
                    }
                }
            }

            int amount = Animals.Count();

            Assert.AreEqual(30, amount);
        }

        [TestMethod()]
        public void SortAnimalsTestFirstInList()
        {
            Train trains = new Train();
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < 5; i++)
            {
                foreach (Animal.Types types in Enum.GetValues(typeof(Animal.Types)))
                {
                    foreach (Animal.Sizes sizes in Enum.GetValues(typeof(Animal.Sizes)))
                    {
                        if (sizes != Animal.Sizes.None)
                        {
                            Animal animal = new Animal("Animal", types, sizes);
                            animals.Add(animal);
                        }
                    }
                }
            }

            animals = trains.SortAnimals(animals);

            Assert.IsTrue(animals[0].Type == Animal.Types.Herbivore && animals[0].Size == Animal.Sizes.Big);
        }

        [TestMethod()]
        public void SortAnimalsTestWholeList()
        {
            trains = new Train();
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < 5; i++)
            {
                foreach (Animal.Types types in Enum.GetValues(typeof(Animal.Types)))
                {
                    foreach (Animal.Sizes sizes in Enum.GetValues(typeof(Animal.Sizes)))
                    {
                        if (sizes != Animal.Sizes.None)
                        {
                            Animal animal = new Animal("Animal", types, sizes);
                            animals.Add(animal);
                        }
                    }
                }
            }
            
            animals = trains.SortAnimals(animals);
            int j = 0;
            if (animals[0].Type == Animal.Types.Herbivore && animals[0].Size == Animal.Sizes.Big)
                j++;
            if (animals[5].Type == Animal.Types.Herbivore && animals[5].Size == Animal.Sizes.Medium)
                j++;
            if (animals[10].Type == Animal.Types.Herbivore && animals[10].Size == Animal.Sizes.Small)
                j++;
            if (animals[15].Type == Animal.Types.Carnivore && animals[15].Size == Animal.Sizes.Big)
                j++;
            if (animals[20].Type == Animal.Types.Carnivore && animals[20].Size == Animal.Sizes.Medium)
                j++;
            if (animals[25].Type == Animal.Types.Carnivore && animals[25].Size == Animal.Sizes.Small)
                j++;

            Assert.AreEqual(6, j);
        }

        [TestMethod()]
        public void FillWagonTest()
        {
            trains = new Train();
            List<Animal> animals = new List<Animal>();
            List<Wagon> wagons = new List<Wagon>();
            for (int i = 0; i < 5; i++)
            {
                foreach (Animal.Types types in Enum.GetValues(typeof(Animal.Types)))
                {
                    foreach (Animal.Sizes sizes in Enum.GetValues(typeof(Animal.Sizes)))
                    {
                        if (sizes != Animal.Sizes.None)
                        {
                            Animal animal = new Animal("Animal", types, sizes);
                            animals.Add(animal);
                        }
                    }
                }
            }

            trains.FillWagon(animals);

            int j = trains.Wagons.Count();

            Assert.AreEqual(20, j);
        }
    }
}