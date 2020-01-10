using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ClassesTests
{
    [TestClass()]
    public class ShipTests
    {
        private Ship _ship;
        private Container _container;
        private List<Container> _containers;

        [TestInitialize]
        public void TestInit()
        {
            _ship = new Ship(2, 2);
            _containers = new List<Container>();
            for (int i = 0; i < 5; i++)
            {
                _container = new Container(Container.Categories.Normal, (i + 4) * 4);
                _containers.Add(_container);
            }
            for (int i = 0; i < 5; i++)
            {
                _container = new Container(Container.Categories.Cooled, (i + 4) * 4);
                _containers.Add(_container);
            }
            for (int i = 0; i < 2; i++)
            {
                _container = new Container(Container.Categories.ValuableCooled, (i + 4) * 4);
                _containers.Add(_container);
            }
            for (int i = 0; i < 2; i++)
            {
                _container = new Container(Container.Categories.Valuable, (i + 4) * 4);
                _containers.Add(_container);
            }
        }
        //[TestMethod()]
        //public void Create_CreateShipOf2By2_IsShipCreated()
        //{
        //    Assert.AreEqual(2, _ship.Width);
        //}

        [TestMethod()]
        public void Calculate_SeeIfShipMaxWeightIsCorrect_MaxWeightOutput()
        {
            // Arrange
            int i;

            // Act
            i = _ship.Lenght * _ship.Width;
            i *= 150;

            // Assert
            Assert.AreEqual(i, _ship.MaxWeight);
        }

        [TestMethod()]
        public void Calculate_SeeIfShipMinWeightIsCorrect_MinWeightOutput()
        {
            // Arrange
            int i;

            // Act
            i = _ship.Lenght * _ship.Width;
            i *= 150;
            i /= 2;

            // Assert
            Assert.AreEqual(i, _ship.MinWeight);
        }

        [TestMethod()]
        public void Create_CreateRows_CorrectTotalRows()
        {
            // Act
            _ship.CreateRows(_ship.Lenght, _ship.Width);

            // Assert
            Assert.AreEqual(_ship.Lenght, _ship.GetRows().Count);
        }

        [TestMethod()]
        public void Sort_SortContainerLists_SortingDone()
        {
            // Arrange


            // Act
            _containers = (List<Container>)_ship.SortContainerByCategory(_containers);

            // Assert
            Assert.IsTrue(_ship.GetContainerNormalList().Count > 0);
            Assert.IsTrue(_ship.GetContainerCooledList().Count > 0);
            Assert.IsTrue(_ship.GetContainerValuableList().Count > 0);
            Assert.IsTrue(_ship.GetContainerValuableCooledList().Count > 0);
        }

        [TestMethod()]
        public void Algorithm_AddContainerToStack_AlgorithmExecuted()
        {
            // Arrange
            int i;
            _ship.SortContainerByCategory(_containers);
            _ship.CreateRows(_ship.Lenght, _ship.Width);

            // Act
            i = _ship.AddContainerToStack(_ship.Width, _ship.Lenght);
            _ship.ReverseStacks();

            // Assert
            Assert.AreEqual(3, i);

            _ship.ClearStacks();
        }

        [TestMethod()]
        public void AlgorithmWithTooManyCooledContainers_AddContainerToStack_AlgorithmExecuted()
        {
            // Arrange
            int i;
            for (int j = 0; j < 30; j++)
            {
                Container container = new Container(Container.Categories.Cooled, 30);
                _containers.Add(container);
            }
            _ship.SortContainerByCategory(_containers);
            _ship.CreateRows(_ship.Lenght, _ship.Width);


            // Act
            i = _ship.AddContainerToStack(_ship.Width, _ship.Lenght);
            _ship.ReverseStacks();

            // Assert
            Assert.AreEqual(1, i);

            _ship.ClearStacks();
        }

        [TestMethod()]
        public void AlgorithmWithTooManyValuableCooledContainers_AddContainerToStack_AlgorithmExecuted()
        {
            // Arrange
            int i;
            Container container = new Container(Container.Categories.ValuableCooled, 15);
            _containers.Add(container);
            _ship.SortContainerByCategory(_containers);
            _ship.CreateRows(_ship.Lenght, _ship.Width);


            // Act
            i = _ship.AddContainerToStack(_ship.Width, _ship.Lenght);
            _ship.ReverseStacks();

            // Assert
            Assert.AreEqual(0, i);

            _ship.ClearStacks();
        }

        [TestMethod()]
        public void AlgorithmWithTooManyValuableContainers_AddContainerToStack_AlgorithmExecuted()
        {
            // Arrange
            int i;
            Container container = new Container(Container.Categories.Valuable, 15);
            _containers.Add(container);
            _ship.SortContainerByCategory(_containers);
            _ship.CreateRows(_ship.Lenght, _ship.Width);


            // Act
            i = _ship.AddContainerToStack(_ship.Width, _ship.Lenght);
            _ship.ReverseStacks();

            // Assert
            Assert.AreEqual(4, i);

            _ship.ClearStacks();
        }
    }
}