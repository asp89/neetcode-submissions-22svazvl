public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;

        for (int i = 0; i < k; i++)
        {
            int last = nums[n - 1];

            for (int j = n - 1; j > 0; j--)
            {
                nums[j] = nums[j-1];
            }
            nums[0] = last;
        }
    }
}