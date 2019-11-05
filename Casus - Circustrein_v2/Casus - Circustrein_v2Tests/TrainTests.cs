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
        Train trains;

        [TestMethod()]
        public void Count_CreateAnimal_AreEqual()
        {
            //arrange
            List<Animal> Animals = new List<Animal>();
            Animal newAnimal = new Animal("Tijger", Animal.Types.Carnivore, Animal.Sizes.Big);
            Animals.Add(newAnimal);

            //act
            int amount = Animals.Count();

            //assert
            Assert.AreEqual(1, amount);
        }

        [TestMethod()]
        public void Count_CreateMultipleAnimals_AreEqual()
        {
            //arrange
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

            //act
            int amount = Animals.Count();

            //assert
            Assert.AreEqual(30, amount);
        }

        [TestMethod()]
        public void SortAnimals_CheckFirstAnimal_IsTrue()
        {
            //arrange
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

            //act
            animals = trains.SortAnimals(animals);

            //assert
            Assert.IsTrue(animals[0].Type == Animal.Types.Herbivore && animals[0].Size == Animal.Sizes.Big);
        }

        [TestMethod()]
        public void SortAnimals_CheckAllCreatedAnimals_IsTrue()
        {
            //arrange
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

            //act
            animals = trains.SortAnimals(animals);

            //assert
            Assert.IsTrue(animals[0].Type == Animal.Types.Herbivore && animals[0].Size == Animal.Sizes.Big);
            Assert.IsTrue(animals[5].Type == Animal.Types.Herbivore && animals[5].Size == Animal.Sizes.Medium);
            Assert.IsTrue(animals[10].Type == Animal.Types.Herbivore && animals[10].Size == Animal.Sizes.Small);
            Assert.IsTrue(animals[15].Type == Animal.Types.Carnivore && animals[15].Size == Animal.Sizes.Big);
            Assert.IsTrue(animals[20].Type == Animal.Types.Carnivore && animals[20].Size == Animal.Sizes.Medium);
            Assert.IsTrue(animals[25].Type == Animal.Types.Carnivore && animals[25].Size == Animal.Sizes.Small);
        }

        [TestMethod()]
        public void FillWagon_CreateWagons_AreEqual()
        {
            //arrange
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

            //act
            trains.FillWagon(animals);

            //assert
            Assert.AreEqual(20, trains.Wagons.Count());
        }
    }
}