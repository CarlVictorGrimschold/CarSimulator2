using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using CarSimulator2.Services;
using CarSimulator2.Models;
using System.Runtime.CompilerServices;

namespace CarSimulator2.Tests
{
    [TestClass]
    public class DriverServiceTests
    {
        private readonly DriverService _driverService;
        [TestMethod]
        public async Task GetRandomDriverDataAsync_ShouldReturnUserData()
        {
           
            // Act
            var userData = await _driverService.GetRandomUserDataAsync();

            // Assert
            Assert.IsNotNull(userData, "UserData should not be null");
           // Assert.IsNotNull(userData.firstName, "UserData.Name.First should not be null");
           // Assert.IsNotNull(userData.lastName, "UserData.Name.Last should not be null");
            
        }
    }
}
