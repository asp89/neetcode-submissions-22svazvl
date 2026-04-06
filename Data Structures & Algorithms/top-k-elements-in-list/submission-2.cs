public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> frequencyMap = new();

        foreach (int num in nums)
            frequencyMap[num] = frequencyMap.GetValueOrDefault(num, 0) + 1;

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var kvp in frequencyMap)
        {
            int frequency = kvp.Value;
            if (buckets[frequency] == null)
                buckets[frequency] = new List<int>();

            buckets[frequency].Add(kvp.Key);
        }

        List<int> result = new();

        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
                result.AddRange(buckets[i]);
        }

        return result.Take(k).ToArray();
    }
}
