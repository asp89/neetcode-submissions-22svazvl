public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);

        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            int x = n - i;

            if (nums[i] >= x && (i == 0 || nums[i - 1] < x)) {
                return x;
            }
        }

        return -1;
    }
}