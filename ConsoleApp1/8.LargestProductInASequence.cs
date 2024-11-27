public class LargestProductInASequence
{
    public static string Solution()
    {
        string numbers = "37862187361236123678126837126873126381263126312783128387116367812638712638716283761287367812361203128903812903821903810958443534563967093795470742304180293812793087129837129843793827492374237409371294719739127391237129734912749372947234927947197412908739172930172931729379172391274987398242398479238749238471902734912074307593475693475932749739473290472930523674163012783701246374324917983712983712980423784872364239847917438127237498237401741297412743912739172312731740384712941299999999999912534125643651243";

        int max = 0;
        string maxValues = "0000000000000";

        for (int i = 0; i < numbers.Length - 13; i++)
        {
            string numsPart = numbers[i..(i + 13)];

            int numsPartAgg = 0;

            if (numsPart.Contains("1") || numsPart.Contains("0"))
            {
                numsPartAgg = numsPart.Aggregate(1, (acc, e) => acc * e);
            }
            else
            {
                numsPartAgg = numsPart.Select(e => e - '0').Sum();
            }


            if (max < numsPartAgg)
            {
                max = numsPartAgg;
                maxValues = numsPart;
            }
        }

        return maxValues;
    }
}