using CarSimulator2.Models;
using CarSimulator2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator2.Tests.Services
{
    [TestClass]
    public class DriverServiceTests
    {
        [TestMethod]
        public async Task GetRandomDriverDataAsync_ShouldReturnUserData()
        {
            // Arrange
            DriverService driverService = new DriverService();
            RandomUserName userData = new RandomUserName();
            // Act
            userData = await driverService.GetRandomUserDataAsync();
            // Assert
            Assert.IsNotNull(userData, "UserData should not be null");
            Assert.IsNotNull(userData.FirstName, "UserData.Name should not be null");
            Assert.IsNotNull(userData.LastName, "UserData.Name.First should not be null");
            
        }
    }
}
