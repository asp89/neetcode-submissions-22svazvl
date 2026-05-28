public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            int currentSum = 0;

            for (int j = i; j < nums.Length; j++)
            {
                currentSum = currentSum + nums[j];
                if (currentSum == k)
                    count++;
            }
        }

        return count;
    }
}