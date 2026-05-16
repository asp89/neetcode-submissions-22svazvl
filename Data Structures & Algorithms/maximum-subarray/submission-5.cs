public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentSum = nums[0];
        int maxSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];
            if (num > currentSum + num)
                currentSum = num;
            else
                currentSum = currentSum + num;

            if (currentSum > maxSum)
                maxSum = currentSum;
        }

        return maxSum;
    }
}
