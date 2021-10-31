using AutoFixture;
using IntecapBooks.Controllers;
using IntecapBooks.Infrastructure.API;
using IntecapBooks.Infrastructure.API.Models;
using IntecapBooks.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntecapBooks.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public async Task Index_ShoudlReturnView()
        {
            // Arrange
            Mock<IExternalBookProviderClient> mockExternalProvider = new Mock<IExternalBookProviderClient>();
            Mock<IBooksService> mockBookService = new Mock<IBooksService>();
            var fixture = new Fixture();
            Task<List<ExternalBook>> expectedExternalBookData = fixture.Create<Task<List<ExternalBook>>>();
            List<BookModel> expectedBookData = fixture.Create<List<BookModel>>();

            mockExternalProvider.Setup(w => w.GetBooks()).Returns(expectedExternalBookData);
            mockBookService.Setup(s => s.GetBooks()).Returns(expectedBookData);

            // Act
            var controller = new HomeController(mockBookService.Object, mockExternalProvider.Object);
            var result = await controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
