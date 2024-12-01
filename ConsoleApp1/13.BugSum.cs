public class BigSum
{
    public static string Solution()
    {
        int PARTS_COUNT = 100;
        int PART_LENGTH = 50;

        string nums = "";

        for (int k = 0; k < PARTS_COUNT; k++)
        {
            string part = "";

            for (int n = 0; n < PART_LENGTH; n++)
            {
                int num = new Random().Next(9);
                part += num.ToString();
            }

            nums += part;
        }

        int j = 0;

        string[] parts = new string[PARTS_COUNT];

        for (int i = 0; i < PARTS_COUNT; i++)
        {
            parts[i] = nums[j..(j + PART_LENGTH)];
            j += PART_LENGTH;
        }

        string result = "";

        int step = 0;

        for (int v = parts[0].Length - 1; v >= 0; v--)
        {
            int posSum = 0;

            foreach (string part in parts)
            {
                posSum += part[v] - '0';
            }

            int calcStep = result.Length - step;
            string calcPart = result[..calcStep];

            result = ((calcPart != "" ? int.Parse(calcPart) : 0) + posSum).ToString() + result[calcStep..];

            step++;
        }

        return result[..10];
    }
}