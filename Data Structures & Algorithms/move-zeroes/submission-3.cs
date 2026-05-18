public class Solution {
    public void MoveZeroes(int[] nums) {
        int idx = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (num != 0)
            {
                nums[idx] = num;
                idx++;
            }
        }

        while (idx < nums.Length)
        {
            nums[idx] = 0;
            idx++;
        }
    }
}