using Microsoft.VisualStudio.TestTools.UnitTesting;
using gbkapp.Models;

namespace gbkapp.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ConstructProduct_ReturnsAProduct_True()
        {
            //Arrange
            var product = new Product();

            //Act
            var result = product.Description;

            //Assert
            Assert.AreEqual("The original Gummi Bear", result);
        }
    }
}