using System;
using System.Collections.Generic;
using System.Text;
// Example usage in Main method
class Program
{
    static void Main(string[] args)
    {
        GeometricCalculator calculator = new GeometricCalculator();

        // Calculate area of a circle
        double circleRadius = 5.0;
        double circleArea = calculator.CalculateArea(circleRadius);
        Console.WriteLine($"Area of circle (radius {circleRadius}): {circleArea:F2}");

        // Calculate area of a rectangle
        double rectLength = 6.0;
        double rectWidth = 4.0;
        double rectArea = calculator.CalculateArea(rectLength, rectWidth);
        Console.WriteLine($"Area of rectangle ({rectLength} x {rectWidth}): {rectArea:F2}");

        // Calculate area of a triangle
        double triangleBase = 8.0;
        double triangleHeight = 3.0;
        double triangleArea = calculator.CalculateArea(triangleBase, triangleHeight);
        Console.WriteLine($"Area of triangle (base {triangleBase}, height {triangleHeight}): {triangleArea:F2}");
    }
}
