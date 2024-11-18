using ShapeLibrary.Interfaces;

namespace ShapeLibrary;

/// <summary>
/// Provides a utility method to calculate the area of a geometric shape.
/// </summary>
public class ShapeCalculator
{
    /// <summary>
    /// Calculates the area of the given shape.
    /// </summary>
    /// <param name="shape">An object implementing the <see cref="IShape"/> interface.</param>
    /// <returns>
    /// The area of the shape as a <see cref="double"/>.
    /// </returns>
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}
