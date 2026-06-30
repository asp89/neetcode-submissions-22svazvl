public class Solution {
    public int SingleNumber(int[] nums) {
        int unique = 0;

        foreach (int num in nums) {
            unique ^= num;
        }

        return unique;
    }
}
