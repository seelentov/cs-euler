
public class LeastMultiple
{
    public static int Solution()
    {
        int res = 0;

        int start = 100;
        int end = 999;

        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                int multipleInt = i * j;

                string multiple = multipleInt.ToString();

                int length = multiple.Length;

                if (length % 2 != 0)
                {
                    continue;
                }

                int center = length / 2;

                string left = multiple[..center];
                string right = multiple[center..];

                char[] charArray = right.ToCharArray();
                Array.Reverse(charArray);
                string rightReverse = new(charArray);

                if (left == rightReverse)
                {
                    res = multipleInt;
                }

            }
        }

        return res;
    }
}
