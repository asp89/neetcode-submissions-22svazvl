public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int currentHeight = Math.Min(heights[left], heights[right]);
            int currentWidth = right - left;
            int currentArea = currentHeight * currentWidth;

            maxArea = Math.Max(maxArea, currentArea);

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}
