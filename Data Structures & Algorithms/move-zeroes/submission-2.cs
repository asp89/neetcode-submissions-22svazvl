public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;

        while (i < nums.Length) {
            while (i < nums.Length && nums[i] != 0) i++;

            int j = i + 1;

            while (j < nums.Length && nums[j] == 0) j++;

            if (j >= nums.Length)
                break;

            (nums[i], nums[j]) = (nums[j], nums[i]);
        }
    }
}