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
        public void AddAnimalTest()
        {
            Wagon wagon = new Wagon();
            Animal animal = new Animal("animal", Animal.Types.Carnivore, Animal.Sizes.Big);
            List<Animal> animals = new List<Animal>();

            animals.Add(animal);

            bool match = wagon.AddAnimal(animal);

            Assert.IsTrue(match);
        }
    }
}