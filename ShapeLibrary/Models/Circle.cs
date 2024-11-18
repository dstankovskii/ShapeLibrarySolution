using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Models;

public class Circle : IShape
{
    public double Radius { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the circle. Must be greater than zero.</param>
    /// <exception cref="ArgumentException">Thrown when the radius is less than or equal to zero.</exception>
    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException("Radius must be greater than zero.");
        Radius = radius;
    }

    /// <summary>
    /// Calculates the area of the circle.
    /// </summary>
    /// <returns>
    /// The area of the circle as a <see cref="double"/>.
    /// </returns>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
