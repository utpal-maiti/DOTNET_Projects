using APIConcepts.Controllers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestProject.xUnit.DataSource;

namespace TestProject.xUnit.UnitTests.ControllerTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void TestMethod2()
        {
            var mock = new Mock<IGetDataRepository>();
            mock.Setup(p => p.GetNameById(1)).Returns("Jignesh");
            HomeController home = new HomeController(mock.Object);
            string result = home.GetNameById(1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Jignesh", result);
        }
    }
}
