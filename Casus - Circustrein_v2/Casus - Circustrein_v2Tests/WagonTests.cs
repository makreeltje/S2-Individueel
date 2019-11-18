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
    public class WagonTests
    {
        [TestMethod()]
        public void AddAnimal_CreateWagonWithAnimal_IsTrue()
        {
            Wagon wagon = new Wagon();
            Animal animal = new Animal("animal", Animal.Types.Carnivore, Animal.Sizes.Big);
            List<Animal> animals = new List<Animal>();

            animals.Add(animal);

            bool match = wagon.AddAnimal(animal);

            Assert.IsTrue(match);
        }

        [TestMethod()]
        public void AddAnimal_CreateWagonWithAnimals_SecondAnimalDoesNotFit()
        {
            Train trains = new Train();
            Animal animal1 = new Animal("animal1", Animal.Types.Carnivore, Animal.Sizes.Big);
            Animal animal2 = new Animal("animal2", Animal.Types.Herbivore, Animal.Sizes.Medium);
            List<Animal> animals = new List<Animal>();

            animals.Add(animal1);
            animals.Add(animal2);

            trains.FillWagon(animals);

            int totalWagons = trains.Wagons.Count;

            Assert.AreEqual(2, totalWagons);
            Assert.IsFalse(trains.Wagons.Capacity == 2);
        }

        [TestMethod()]
        public void AddAnimal_CreateWagonWithAnimals_SecondAnimalDoesFit()
        {
            Train trains = new Train();
            Animal animal1 = new Animal("animal1", Animal.Types.Herbivore, Animal.Sizes.Big);
            Animal animal2 = new Animal("animal2", Animal.Types.Herbivore, Animal.Sizes.Medium);
            List<Animal> animals = new List<Animal>();

            animals.Add(animal1);
            animals.Add(animal2);

            trains.FillWagon(animals);

            int totalWagons = trains.Wagons.Count;

            Assert.AreEqual(1, trains.Wagons.Count);
            Assert.IsTrue(trains.Wagons[0].Animals.Count == 2);
        }

        [TestMethod()]
        public void AddAnimal_CreateWagonWithAnimals_OptimalSeperation()
        {
            Train trains = new Train();
            Animal animal1 = new Animal("animal1", Animal.Types.Herbivore, Animal.Sizes.Big);
            Animal animal2 = new Animal("animal2", Animal.Types.Herbivore, Animal.Sizes.Big);
            Animal animal3 = new Animal("animal3", Animal.Types.Carnivore, Animal.Sizes.Small);
            Animal animal4 = new Animal("animal4", Animal.Types.Herbivore, Animal.Sizes.Big);
            Animal animal5 = new Animal("animal5", Animal.Types.Herbivore, Animal.Sizes.Big);
            List<Animal> animals = new List<Animal>();

            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);
            animals.Add(animal5);


            trains.FillWagon(animals);

            Assert.AreEqual(3, trains.Wagons.Count);
            Assert.IsTrue(trains.Wagons[0].Animals.Count == 2);
            Assert.IsTrue(trains.Wagons[1].Animals.Count == 2);
            Assert.IsTrue(trains.Wagons[2].Animals.Count == 1);
        }
    }
}