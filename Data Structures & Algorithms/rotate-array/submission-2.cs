public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;

        // Reverse the entire collection
        Reverse(0, n - 1, nums);

        // Reverse the first K elements
        Reverse(0, k - 1, nums);

        // Reverse the remaining elements
        Reverse(k, n - 1, nums);
    }

    public void Reverse(int start, int end, int[] nums) {
        while (start < end) {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}