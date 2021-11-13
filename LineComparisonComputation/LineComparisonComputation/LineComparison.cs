using System;
using System.Collections.Generic;
using System.Text;
namespace LineComparisonComputation
{
    class LineComparison
    {
        double xOnePt, xTwoPt, yOnePt, yTwoPt;
        public LineComparison(double xOnePt, double xTwoPt, double yOnePt, double yTwoPt)
        {
            this.xOnePt = xOnePt;
            this.xTwoPt = xTwoPt;
            this.yOnePt = yOnePt;
            this.yTwoPt = yTwoPt;
        }
        public double LengthCalc()
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(this.xTwoPt - this.xOnePt, 2)) + Math.Sqrt(Math.Pow(this.yTwoPt - this.yOnePt, 2)));
            return Math.Sqrt(Math.Pow(this.xTwoPt - this.xOnePt, 2)) + Math.Sqrt(Math.Pow(this.yTwoPt - this.yOnePt, 2));
        }
        public void Check(double lengthOne, double lengthTwo)
        {
            if (lengthOne.CompareTo(lengthTwo) == 0)
            {
                Console.WriteLine("The two lines are equal");
            }
            if (lengthOne.CompareTo(lengthTwo) < 0)
            {
                Console.WriteLine("The second line is greater than first line");
            }
            if (lengthOne.CompareTo(lengthTwo) > 0)
            {
                Console.WriteLine("The first line is greater than second line");
            }
        }
    }
}

