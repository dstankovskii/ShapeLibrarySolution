using NUnit.Framework;
using ShapeLibrary.Models;

namespace ShapeLibraryTests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void Triangle_Area_Calculation()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.CalculateArea(), Is.EqualTo(6));
    }

    [Test]
    public void Triangle_Is_Right()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRightTriangle(), Is.True);
    }

    [Test]
    public void Triangle_Is_Not_Right()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.That(triangle.IsRightTriangle(), Is.False);
    }

    [Test]
    public void Invalid_Triangle_Sides_Throws_Exception()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
    }
}
