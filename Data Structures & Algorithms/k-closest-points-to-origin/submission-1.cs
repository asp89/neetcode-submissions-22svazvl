public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var maxHeap = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            // 0, 2 = 4
            // 2, 2 = 8
            int dist = point[0] * point[0]+ point[1] * point[1];

            // [0, 2], -4
            // [2, 2], -8
            maxHeap.Enqueue(point, -dist);

            // false
            // true
            if (maxHeap.Count > k)
                maxHeap.Dequeue(); // removed [2, 2]
        }

        int[][] result = new int[k][];

        for (int i = 0; i < k; i++)
            result[i] = maxHeap.Dequeue();

        return result;        
    }
}
