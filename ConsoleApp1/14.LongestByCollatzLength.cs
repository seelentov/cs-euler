public class LongestByCollatzLength
{
    public static int Solution()
    {
        Dictionary<long, int> queues = [];

        int maxQueue = 0;
        int maxQueueLength = 0;

        for (int i = 1; i < 1000000; i++)
        {
            long num = i;

            int queueLength = 1;

            while (num != 1)
            {
                if (queues.ContainsKey(num))
                {
                    int alredyCalculated = queues[num];

                    queueLength += alredyCalculated - 1;
                    Console.WriteLine(i + " already exist: " + alredyCalculated);
                    break;
                }

                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num * 3 + 1;
                }
                queueLength++;
            }

            queues.Add(i, queueLength);

            Console.WriteLine(i + " calculated: " + queueLength);

            if (queueLength > maxQueueLength)
            {
                maxQueueLength = queueLength;
                maxQueue = i;
            }
        }

        return maxQueue;
    }
}