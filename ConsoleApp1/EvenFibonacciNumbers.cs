using System;

namespace ConsoleApp1;

public class EvenFibonacciNumbers
{
    public static int Solution(int limit)
    {
        int first = 1;
        int second = 1;

        int res = 2;

        while (true)
        {
            int tempFirst = first;
            first = second;
            second += tempFirst;

            if (second > limit)
            {
                break;
            }

            if (second % 2 == 0)
            {
                res += second;
            }
        }

        return res;
    }
}
