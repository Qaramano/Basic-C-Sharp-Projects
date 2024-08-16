using System;
using System.Collections.Generic;
using System.Text;

    // GeometricCalculator class to calculate areas of shapes
    class GeometricCalculator
    {
        // Calculate area of a circle
        public double CalculateArea(double radius)
        {
            // Formula: A = πr^2
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        // Calculate area of a rectangle
        public double CalculateArea(double length, double width)
        {
            // Formula: A = length * width
            double area = length * width;
            return area;
        }

        // Calculate area of a triangle
        public double CalculateArea1(double baseLength, double height)
        {
            // Formula: A = 0.5 * base * height
            double area = 0.5 * baseLength * height;
            return area;
        }
    }


