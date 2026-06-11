using System;

namespace Methods
{
    public static class MathShortcuts
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine($"The value of {x} + {y} = {x + y}");
        }

        public static void AddAll(double[] values)
        {
            double result = 0;
            //values.Sum(); could be used instead of foreach but this is just a sample
            foreach (var value in values)
            {
                result += value;
            }

            Console.WriteLine($"The total is {result}");
        }
    }
}
