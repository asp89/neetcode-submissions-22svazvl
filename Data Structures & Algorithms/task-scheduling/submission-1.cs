public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];

        foreach (char task in tasks) freq[task - 'A']++;

        var maxHeap = new PriorityQueue<int, int>();

        foreach (int count in freq) {
            if (count > 0)
                maxHeap.Enqueue(count, -count);
        }

        Queue<(int count, int availableTime)> cooldown = new();

        int time = 0;

        while (maxHeap.Count > 0 || cooldown.Count > 0) {
            time++;

            while (cooldown.Count > 0 && cooldown.Peek().availableTime <= time) {
                var task = cooldown.Dequeue();
                maxHeap.Enqueue(task.count, -task.count);
            }

            if (maxHeap.Count > 0) {
                int count = maxHeap.Dequeue() - 1;

                if (count > 0)
                    cooldown.Enqueue((count, time + n + 1));
            }
        }

        return time;
    }
}
