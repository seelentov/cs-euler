public class GreatestPrimeDivisor
{
    private static int Solution(int num)
    {
        int res = 1;

        for (int i = 2; i < num; i++)
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

            if (num % i == 0 && i > res)
            {
                res = i;
            }
        }

        return res;
    }
}
