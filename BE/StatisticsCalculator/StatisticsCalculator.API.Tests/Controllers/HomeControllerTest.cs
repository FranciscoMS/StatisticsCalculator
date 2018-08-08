using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator.API;
using StatisticsCalculator.API.Controllers;

namespace StatisticsCalculator.API.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            ViewResult result = controller.Get() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
