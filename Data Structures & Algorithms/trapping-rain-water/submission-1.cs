public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;

        if (n == 0)
            return 0;

        int[] prefix = new int[n];
        prefix[0] = height[0];

        int[] suffix = new int[n];
        suffix[n - 1] = height[n - 1];

        for (int i = 1; i < n; i++) prefix[i] = Math.Max(prefix[i - 1], height[i]);

        for (int i = n - 2; i >= 0; i--) suffix[i] = Math.Max(suffix[i + 1], height[i]);

        int result = 0;
        for (int i = 0; i < n; i++) result += Math.Min(prefix[i], suffix[i]) - height[i];

        return result;
    }
}
