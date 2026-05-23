public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) 
        {
            int minVal = Math.Min(heights[left], heights[right]);
            
            int width = right - left;
            
            int currentVal = minVal * width;

            max = Math.Max(max, currentVal);

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }
        
        return max;
    }
}
