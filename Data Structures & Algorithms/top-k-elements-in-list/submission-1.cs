public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> counter = new();

        foreach (int num in nums)
        {
            if (counter.ContainsKey(num))
                counter[num]++;
            else
                counter[num] = 1;
        }

        return counter
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
