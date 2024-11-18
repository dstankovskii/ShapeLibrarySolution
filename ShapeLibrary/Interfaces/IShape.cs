namespace ShapeLibrary.Interfaces;

/// <summary>
/// Represents a geometric shape that can calculate its own area.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns>
    /// The area of the shape as a <see cref="double"/>.
    /// </returns>
    double CalculateArea();
}
