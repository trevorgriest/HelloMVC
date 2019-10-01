using System;
using Xunit;
using HelloMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
    public class GreetControllerTests
    {
        [Fact]
        public void Index_Returns_GreetingModel_To_View()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<GreetingModel>(result.Model);
        }
        [Fact]
        public void Index_Sets_Name_On_Model()
        {
            var expectedName = "ExampleString";
            var controller = new GreetingController();

            var result = controller.Index(expectedName);

            var model = (GreetingModel)result.Model;
            Assert.Equal(expectedName, model.Name);
        }
    }
}
