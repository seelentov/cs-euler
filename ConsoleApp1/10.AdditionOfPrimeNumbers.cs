namespace ConsoleApp1;

public class AdditionOfPrimeNumbers
{
    public static int Solution()
    {
        List<int> resApp = [];

        for (int i = 2; i < 10; i++)
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

            resApp.Add(i);
        }

        return resApp.Sum();
    }
}