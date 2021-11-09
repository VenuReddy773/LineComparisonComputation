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
            if (lengthOne.Equals(lengthTwo))
                Console.WriteLine("Two lines are equal");
            else
                Console.WriteLine("Two lines are not equal");
        }
    }
}


