public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int left = 0, right = heights.Length - 1;

        while (left < right)
        {
            int minVal = Math.Min(heights[left], heights[right]);
            int currentValue = minVal * (right - left);
            result = Math.Max(result, currentValue);

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }

        return result;
    }
}
