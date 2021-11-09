using System;

namespace LearningStringInterpolation
{
    class Interpolation
    {
        static void Main(string[] args)
        {
            var point = new { x = 1.1234, y = 2.1254 };

            Console.WriteLine($"x {point.x} y {point.y,10:N1:}");
        }
    }
}
