using System;
namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Progam");
            LineComparison lineOne = new LineComparison(1.5,2.5,3.5,4.5);
            double lengthOne = lineOne.LengthCalc();
            Console.WriteLine("The length of the first line is {0}", lengthOne);
            LineComparison lineTwo = new LineComparison(2.5, 9.5, 7.5, 5.5);
            double lengthTwo = lineTwo.LengthCalc();
            Console.WriteLine("The length of the second line is {0}", lengthTwo);
            lineTwo.Check(lengthOne, lengthTwo);
        }
    }
}
