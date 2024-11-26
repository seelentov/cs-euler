
using System;

namespace ConsoleApp1;

public class TheDifferenceBetweenTheSumOfSquaresAndTheSquareOfTheSum
{
    private static int Solution(int[] ints)
    {
        int sumsq = (int)Math.Pow(ints.Sum(x => x), 2);
        int sqsum = ints.Sum(x => (int)Math.Pow(x, 2));
        return sumsq - sqsum;
    }
}
