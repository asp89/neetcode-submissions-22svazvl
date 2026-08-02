public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];

        foreach (char t in tasks)
            freq[t - 'A']++;
        
        int maxFreq = 0;

        foreach (int count in freq)
            maxFreq = Math.Max(maxFreq, count);
        
        int maxCount = 0;

        foreach (int count in freq)
            if (count == maxFreq)
                maxCount++;
        
        return Math.Max(tasks.Length, (maxFreq - 1) * (n + 1) + maxCount);
    }
}
