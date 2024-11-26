using System;

namespace ConsoleApp1;

public class StPrimeNumber
{
    public static int Solution(int index)
    {
        int counter = 1;

        for (int i = 2; i < int.MaxValue; i++)
        {
            bool skip = false;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    skip = true;
                }
            }

            if (skip)
            {
                continue;
            }

            if (counter == index)
            {
                return i;
            }
            else
            {
                counter++;
            }
        }

        return 0;
    }
}