using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gpkapp.Tests.ControllerTests
{
    [TestMethod]
    public void ProductsController_AddsProductToIndexModelData_Collection()
    {
        // Arrange
        ProductsController controller = new ProductsController();
        Product testProduct = new Product();
        testProduct.Description = "test item";

        // Act
        controller.Create(testProduct);
        ViewResult indexView = new ProductsController().Index() as ViewResult;
        var collection = indexView.ViewData.Model as List<Product>;

        // Assert
        CollectionAssert.Contains(collection, testProduct);
    }
