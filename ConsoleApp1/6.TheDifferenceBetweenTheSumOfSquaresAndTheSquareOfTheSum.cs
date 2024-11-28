
public class TheDifferenceBetweenTheSumOfSquaresAndTheSquareOfTheSum
{
    public static int Solution(int[] ints)
    {
        int sumsq = (int)Math.Pow(ints.Sum(x => x), 2);
        int sqsum = ints.Sum(x => (int)Math.Pow(x, 2));
        return sumsq - sqsum;
    }
}
