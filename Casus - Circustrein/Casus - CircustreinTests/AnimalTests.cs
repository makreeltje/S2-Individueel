using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casus___Circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Circustrein.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        private   animalList;
        [TestInitialize]
        public void TestInitialize()
        {
            animalList = new Animal();
        }
        [TestMethod()]
        public void AnimalTest()
        {
            int amount = Animal.Count();
                
            Assert.AreEqual(0, amount);
        }
    }
}