public class KthLargest {
    private readonly PriorityQueue<int, int> MinHeap = new PriorityQueue<int, int>();
    private readonly int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;

        foreach (int num in nums) Add(num);
    }

    public int Add(int val) {
        if (MinHeap.Count < k) {
            MinHeap.Enqueue(val, val);
        } else if (val > MinHeap.Peek()) {
            MinHeap.Dequeue();
            MinHeap.Enqueue(val, val);
        }

        return MinHeap.Peek();
    }
}
