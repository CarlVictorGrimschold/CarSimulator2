using CarSimulator2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator2.Tests.Services
{
    [TestClass]
    public class CarDirectionTests
    {

        private readonly CarService _sut;
        public CarDirectionTests()
        {
            _sut = new CarService();
        }
        [TestMethod]
        public void CurrentDirectionNorth_Turn_Left()
        {
            var direction = "Norrut";
            var expectend = "Västerut";
            var result = _sut.TurnLeft(direction);
            Assert.AreEqual(expectend, result);


        }
        [TestMethod]
        public void CurrentDirectionWest_Turn_Left()
        {
            var direction = "Västerut";
            var expectend = "Söderut";
            var result = _sut.TurnLeft(direction);
            Assert.AreEqual(expectend, result);


        }
        [TestMethod]
        public void CurrentDirectionSouth_Turn_Left()
        {
            var direction = "Söderut";
            var expectend = "Österut";
            var result = _sut.TurnLeft(direction);
            Assert.AreEqual(expectend, result);
        }
        [TestMethod]
        public void CurrentDirectionEast_Turn_Left()
        {
            var direction = "Söderut";
            var expectend = "Österut";
            var result = _sut.TurnLeft(direction);
            Assert.AreEqual(expectend, result);
        }
        [TestMethod]
        public void CurrentDirectionNorth_Turn_Right()
        {
            var direction = "Norrut";
            var expectend = "Österut";
            var result = _sut.TurnRight(direction);
            Assert.AreEqual(expectend, result);
        }
        [TestMethod]
        public void CurrentDirectionWest_Turn_Right()
        {
            var direction = "Västerut";
            var expectend = "Norrut";
            var result = _sut.TurnRight(direction);
            Assert.AreEqual(expectend, result);
        }
        [TestMethod]
        public void CurrentDirectionSouth_Turn_Right()
        {
            var direction = "Söderut";
            var expectend = "Västerut";
            var result = _sut.TurnRight(direction);
            Assert.AreEqual(expectend, result);
        }
        [TestMethod]
        public void CurrentDirectionEast_Turn_Right()
        {
            var direction = "Österut";
            var expectend = "Söderut";
            var result = _sut.TurnRight(direction);
            Assert.AreEqual(expectend, result);
        }
    }
}
