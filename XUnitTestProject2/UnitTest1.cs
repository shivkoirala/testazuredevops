using System;
using Xunit;
using WebApplication3.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        private readonly Mock<ILogger<HomeController>> _mockRepo=null;

        [Fact]
        public void Test1()
        {
            var _mockRepo = new Mock<ILogger<HomeController>>();

            HomeController x = new HomeController(_mockRepo.Object);
            var result = x.Index() as ViewResult;
            Assert.Equal("SomeData", result.ViewData["vd"]);
        }
    }
}
