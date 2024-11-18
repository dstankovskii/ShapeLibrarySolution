using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Models;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
    /// </summary>
    /// <param name="sideA">The length of the first side. Must be greater than zero.</param>
    /// <param name="sideB">The length of the second side. Must be greater than zero.</param>
    /// <param name="sideC">The length of the third side. Must be greater than zero.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when any side is less than or equal to zero, or when the sides do not satisfy the triangle inequality.
    /// </exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) 
            throw new ArgumentException("Sides must be greater than zero.");
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) 
            throw new ArgumentException("Invalid triangle sides.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    /// Calculates the area of the triangle using Heron's formula.
    /// </summary>
    /// <returns>
    /// The area of the triangle as a <see cref="double"/>.
    /// </returns>
    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// Determines whether the triangle is a right triangle using the Pythagorean theorem.
    /// </summary>
    /// <returns>
    /// <c>true</c> if the triangle is a right triangle; otherwise, <c>false</c>.
    /// </returns>
    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC }.OrderBy(x => x).ToArray();
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }
}
