using MockSample.Interface;
using Moq;
using Xunit;

namespace MockSample.Service
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetProductCount_ShouldReturnCorrectCount()
        {
            // Arrange
            var mockRepo = new Mock<IProductRepository>();
            mockRepo.Setup(r => r.GetAll()).Returns(new List<string> { "Laptop", "Phone" });

            var service = new ProductService(mockRepo.Object);

            // Act
            var count = service.GetProductCount();

            // Assert
            Assert.Equal(2, count);
        }
    }
}
