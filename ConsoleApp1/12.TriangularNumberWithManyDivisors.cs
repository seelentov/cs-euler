public class TriangularNumberWithManyDivisors
{
    public static int Solution()
    {
        int acc = 1;

        for (int i = 2; i <= int.MaxValue; i++)
        {
            acc += i;

            int dividerCount = 2;

            int maxDiv = (int)Math.Sqrt(acc) + 1;

            for (int j = 2; j < maxDiv; j++)
            {
                if (acc % j == 0)
                {
                    if (acc / j == j)
                    {
                        dividerCount++;
                    }
                    else
                    {
                        dividerCount += 2;
                    }
                }
            }

            Console.WriteLine(acc + " " + dividerCount);

            if (dividerCount > 500)
            {
                return acc;
            }
        }

        return 2;
    }
}