public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqMap = new();

        foreach (int n in nums) freqMap[n] = freqMap.GetValueOrDefault(n, 0) + 1;

        PriorityQueue<int, int> minHeap = new();

        foreach (var kvp in freqMap)
        {
            minHeap.Enqueue(kvp.Key, kvp.Value);

            if (minHeap.Count > k)
                minHeap.Dequeue();
        }

        int[] result = new int[k];

        for (int i = k - 1; i >= 0; i--)
        {
            result[i] = minHeap.Dequeue();
        }

        return result;
    }
}
