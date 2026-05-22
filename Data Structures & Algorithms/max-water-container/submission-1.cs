public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i + 1; j < heights.Length; j++)
            {
                int min = Math.Min(heights[i], heights[j]);
                int product = (j - i) * min;
                max = Math.Max(max, product);
            }
        }

        return max;
    }
}
