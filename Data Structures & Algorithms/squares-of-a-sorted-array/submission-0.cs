public class Solution {
    public int[] SortedSquares(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            int currentNumber = nums[i] * nums[i];
            nums[i] = currentNumber;
        }
        Array.Sort(nums);
        return nums;
    }
}