public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var maxHeap = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            int dist = point[0] * point[0]+ point[1] * point[1];

            maxHeap.Enqueue(point, -dist);

            if (maxHeap.Count > k)
                maxHeap.Dequeue();
        }

        int[][] result = new int[k][];

        for (int i = 0; i < k; i++)
            result[i] = maxHeap.Dequeue();

        return result;        
    }
}
