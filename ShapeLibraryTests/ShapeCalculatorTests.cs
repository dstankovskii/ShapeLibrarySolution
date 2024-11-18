using NUnit.Framework;
using ShapeLibrary;
using ShapeLibrary.Interfaces;
using ShapeLibrary.Models;

namespace ShapeLibraryTests;

[TestFixture]
public class ShapeCalculatorTests
{
    [Test]
    public void ShapeCalculator_Calculates_Circle_Area()
    {
        IShape shape = new Circle(1);
        Assert.That(ShapeCalculator.CalculateArea(shape), Is.EqualTo(Math.PI));
    }

    [Test]
    public void ShapeCalculator_Calculates_Triangle_Area()
    {
        IShape shape = new Triangle(3, 4, 5);
        Assert.That(ShapeCalculator.CalculateArea(shape), Is.EqualTo(6));
    }
}
