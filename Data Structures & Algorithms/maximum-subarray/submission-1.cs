public class Solution {
    public int MaxSubArray(int[] nums)
    {
        int answer = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum = sum + nums[j];
                answer = Math.Max(answer, sum);
            }
        }

        return answer;
    }
}
