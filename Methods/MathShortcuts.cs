using System;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y) // returns a double
        {
            //Console.WriteLine($"The value of {x} + {y} = {x + y}");
            double output = x + y;
            return output;
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
