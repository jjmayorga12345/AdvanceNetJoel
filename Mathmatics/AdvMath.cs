using System;
using System.Collections.Generic;
using System.Linq;

namespace Mathmatics
{
    public class AdvMath
    {
        public double CalculateArea(double height, double width)
        {
            return height * width;
        }

        public double CalculateAverage(List<double> numbers) 
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("cant be null");

            return numbers.Average();
        }

        public double CalculateSquared(double value)
        {
            return value * value;
        }

        public double CalculateHypotenuse(double a, double b)
        {
            return Math.Sqrt((a * a) + (b * b));
        }
    }
}
