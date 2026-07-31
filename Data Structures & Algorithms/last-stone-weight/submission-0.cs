public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new PriorityQueue<int, int>();

        foreach (int stone in stones) heap.Enqueue(stone, -stone);

        while (heap.Count > 1) {
            int first = heap.Dequeue();
            int second = heap.Dequeue();

            if (first != second) {
                int diff = first - second;
                heap.Enqueue(diff, -diff);
            }
        }

        return heap.Count == 0 ? 0 : heap.Peek();
    }
}
