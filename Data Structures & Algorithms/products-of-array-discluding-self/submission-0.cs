public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i <nums.Length; i++)
        {
            // traverse elements from left to right
            result[i] = prefix;
            prefix = prefix * nums[i];
        }

        int suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = result[i] * suffix;
            suffix = suffix * nums[i];
        }

        return result;
    }
}
