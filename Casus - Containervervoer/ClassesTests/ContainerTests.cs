using System.Collections.Generic;
using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesTests
{
    [TestClass()]
    public class ContainerTests
    {
        private Container _container;
        private Container _containerNormal;
        private Container _containerCooled;
        private Container _containerValuable;
        private Container _containerCooledValuable;
        private Container _containerAboveMaxWeight;
        private Container _containerBelowMinWeight;
        private List<Container> _allContainers;

        [TestInitialize]
        public void InitTest() 
        {

            _container = new Container(Container.Categories.None, 0);
            _containerAboveMaxWeight = new Container(Container.Categories.None, 31);
            _containerBelowMinWeight = new Container(Container.Categories.None, 3);
            _containerNormal = new Container(Container.Categories.Normal, 10);
            _containerCooled = new Container(Container.Categories.Cooled, 10);
            _containerValuable = new Container(Container.Categories.Valuable, 10);
            _containerCooledValuable = new Container(Container.Categories.ValuableCooled, 10);

            _allContainers = new List<Container>();

            for (int i = 0; i < 10; i++)
            {
                _allContainers.Add(_containerNormal);
                _allContainers.Add(_containerCooled);
                _allContainers.Add(_containerValuable);
                _allContainers.Add(_containerCooledValuable);
            }
        }
        [TestMethod()]
        public void Create_CreateNormalContainer_SeeIfCreated()
        {
            // Assert
            Assert.AreEqual(Container.Categories.Normal, _containerNormal.Category);
        }

        [TestMethod()]
        public void Create_CreateCooledContainer_SeeIfCreated()
        {
            // Assert
            Assert.AreEqual(Container.Categories.Cooled, _containerCooled.Category);
        }

        [TestMethod()]
        public void Create_CreateValuableContainer_SeeIfCreated()
        {
            // Assert
            Assert.AreEqual(Container.Categories.Valuable, _containerValuable.Category);
        }

        [TestMethod()]
        public void Create_CreateCooledValuableContainer_SeeIfCreated()
        {
            // Assert
            Assert.AreEqual(Container.Categories.ValuableCooled, _containerCooledValuable.Category);
        }

        [TestMethod()]
        public void Check_CheckWeightOfContainers_MaxWeightIsExceeded()
        {
            // Assert
            Assert.IsTrue(_container.CheckWeightContainer(_containerAboveMaxWeight.Weight));
        }
        [TestMethod()]
        public void Check_CheckWeightOfContainers_MinWeightIsExceeded()
        {
            // Assert
            Assert.IsTrue(_container.CheckWeightContainer(_containerBelowMinWeight.Weight));
        }
        [TestMethod()]
        public void Check_CheckWeightOfContainers_WeightIsCorrect()
        {
            // Assert
            Assert.IsFalse(_container.CheckWeightContainer(_containerNormal.Weight));
        }

        [TestMethod()]
        public void Check_CheckWeightOfAllContainers_WeightDoesNotExceedThreshold()
        {
            // Arrange
            Ship ship;

            // Act
            ship = new Ship(2,2);

            // Assert
            Assert.IsTrue(_container.CheckTotalWeightContainer(ship.MinWeight,ship.MaxWeight, _allContainers));
        }

        [TestMethod()]
        public void Check_CheckWeightOfAllContainers_WeightDoesExceedMaxThreshold()
        {
            // Arrange
            Ship ship;

            // Act
            ship = new Ship(1, 1);

            // Assert
            Assert.IsFalse(_container.CheckTotalWeightContainer(ship.MinWeight, ship.MaxWeight, _allContainers));
        }

        [TestMethod()]
        public void Check_CheckWeightOfAllContainers_WeightDoesExceedMinThreshold()
        {
            // Arrange
            Ship ship;

            // Act
            ship = new Ship(3, 3);

            // Assert
            Assert.IsFalse(_container.CheckTotalWeightContainer(ship.MinWeight, ship.MaxWeight, _allContainers));
        }

        [TestMethod()]
        public void Check_OverrideString_SeeWhatResultComesUp()
        {
            // Arrange
            Container container;
            
            // Act
            container = new Container(Container.Categories.Normal, 30);

            // Assert
            Assert.AreEqual("Weight: 30, Category: Normal", container.ToString());
        }
    }
}