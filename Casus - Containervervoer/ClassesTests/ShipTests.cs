using Microsoft.VisualStudio.TestTools.UnitTesting;
using Casus___Containervervoer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Casus___Containervervoer.Tests
{
    [TestClass()]
    public class ShipTests
    {
        private Ship _ship;

        [TestInitialize]
        public void TestInit()
        {
            _ship = new Ship(2, 2);
        }
        [TestMethod()]
        public void Create_CreateShipOf2By2_IsShipCreated()
        {
            Assert.AreEqual(2, _ship.Width);
        }

        [TestMethod()]
        public void Calculate_SeeIfShipMaxWeightIsCorrect_MaxWeightOutput()
        {
            Assert.AreEqual(600, _ship.MaxWeight);
        }

        [TestMethod()]
        public void Calculate_SeeIfShipMinWeightIsCorrect_MinWeightOutput()
        {
            Assert.AreEqual(300, _ship.MinWeight);
        }
    }
}