using NUnit.Framework;
using ShapeLibrary.Models;

namespace ShapeLibraryTests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void Circle_Area_Calculation()
    {
        var circle = new Circle(1);
        Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI));
    }

    [Test]
    public void Invalid_Circle_Radius_Throws_Exception()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}
