using NUnit.Framework;
using ConsoleApp6;

namespace ConsoleApp6.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void Circle_Area_Correct()
        {
            // Arrange
            var circle = new Circle(5);
            double expectedArea = Math.PI * Math.Pow(5, 2);

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-6));
        }

        [Test]
        public void Triangle_Area_Correct()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-6));
        }

        [Test]
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.That(isRight, Is.True);
        }
    }
}
