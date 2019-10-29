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
        public Animal animals;
        Train trains;

        [TestInitialize()]
        public void TestInitialize()
        {
            animals = new Animal();
            trains = new Train();
        }

        [TestMethod()]
        public void FillWagonTest()
        {
            Train Trains = new Train();
            List<Animal> Animals = new List<Animal>();
            Animal newAnimal = new Animal("Tijger", Animal.Types.Carnivore, Animal.Sizes.Big);
            Animals.Add(newAnimal);

            Trains.FillWagon(Animals);

            int amount = Animals.Count();

            Assert.AreEqual(1, amount);
        }

        [TestMethod()]
        public void SortAnimalsTest()
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

            Animal animals = new Animal();

            trains.SortAnimals(Animals);

            Assert.AreEqual(30, amount);
        }
    }
}