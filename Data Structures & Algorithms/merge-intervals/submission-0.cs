public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
            return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        Console.WriteLine(string.Join(" | ", intervals.Select(x => $"[{x[0]},{x[1]}]")));

        List<int[]> merged = new();
        int[] current = intervals[0];
        Console.WriteLine(string.Join(" | ", current.Select(x => $"{x}")));
        merged.Add(current);

        for (int i = 0; i < intervals.Length; i++) {
            int currStart = current[0];
            int currEnd = current[1];

            int nextStart = intervals[i][0];
            int nextEnd = intervals[i][1];

            if (nextStart <= currEnd)
                current[1] = Math.Max(currEnd, nextEnd);
            else {
                current = intervals[i];
                merged.Add(current);
            }
        }
        return merged.ToArray();
    }
}