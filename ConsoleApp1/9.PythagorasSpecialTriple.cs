namespace ConsoleApp1;


public class PythagorasSpecialTriple
{
    public static string? Solution()
    {
        int cycleStart = 1;
        int cycleEnd = 999;

        for (int a = cycleStart; a <= cycleEnd; a++)
        {
            for (int b = cycleStart; b <= cycleEnd; b++)
            {
                for (int c = cycleStart; c <= cycleEnd; c++)
                {
                    if ((a + b + c) == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        return a + "^2 " + b + "^2 = " + c + "^2";
                    }
                }
            }
        }

        return null;
    }
}