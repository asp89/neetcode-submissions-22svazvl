public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = [];

        foreach (int num in nums) map[num] = map.GetValueOrDefault(num) + 1;

        PriorityQueue<int, int> heap = new();

        foreach (var (key, value) in map) {
            heap.Enqueue(key, value);

            if (heap.Count > k)
                heap.Dequeue();
        }

        int[] result = new int[k];

        for (int i = k - 1; i >= 0; i--) result[i] = heap.Dequeue();

        return result;
    }
}
