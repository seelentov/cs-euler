using System;

namespace ConsoleApp1;

public class NumbersThatAreMultiplesOf3Or5
{
    public static int Solution(int limit)
    {
        int res = 0;
        for (int i = 3; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                res += i;
            }
        }

        return res;
    }
}
