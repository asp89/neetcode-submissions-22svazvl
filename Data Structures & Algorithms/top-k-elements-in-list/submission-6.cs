public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freqMap = new();

        foreach (int n in nums)
            freqMap[n] = freqMap.GetValueOrDefault(n, 0) + 1;
        
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var kvp in freqMap)
        {
            int freq = kvp.Value;

            if (buckets[freq] == null) 
                buckets[freq] = new();
            
            buckets[freq].Add(kvp.Key);
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
