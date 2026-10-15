public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
            return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new();
        int[] current = intervals[0];
        merged.Add(current);

        for (int i = 1; i < intervals.Length; i++) {
            int currEnd = current[1];
            int nextStart = intervals[i][0];

            if (nextStart <= currEnd)
                current[1] = Math.Max(currEnd, intervals[i][1]);
            else {
                current = intervals[i];
                merged.Add(current);
            }
        }
        return merged.ToArray();
    }
}