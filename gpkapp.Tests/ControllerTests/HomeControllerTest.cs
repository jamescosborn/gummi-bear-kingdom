using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using gbkapp.Controllers;
using gbkapp.Models;

namespace gbkapp.Tests
{
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
        //Arange
        HomeController controller = new HomeController();

        //Act
        IActionResult indexView = controller.Index();
        ViewResult result = indexView as ViewResult;

        //Assert
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_ProductList()
    {
        //Arrange
        ViewResult indexView = new HomeController().Index() as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(List<Product>));
    }
}
