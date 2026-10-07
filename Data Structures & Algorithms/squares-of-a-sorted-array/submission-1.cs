public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        int[] result = new int[nums.Length];

        for (int i = nums.Length - 1; i >= 0; i--) {
            int leftSq = nums[left] * nums[left];
            int rightSq = nums[right] * nums[right];

            if (leftSq > rightSq) {
                result[i] = leftSq;
                left++;
            } else {
                result[i] = rightSq;
                right--;
            }
        }
        return result;
    }
}