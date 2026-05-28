public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        dict[0] = 1;

        int currentSum = 0;
        int count = 0;

        foreach (int num in nums)
        {
            currentSum = currentSum + num;

            if (dict.ContainsKey(currentSum - k))
                count = count + dict[currentSum - k];
            
            if (dict.ContainsKey(currentSum))
                dict[currentSum]++;
            else
                dict[currentSum] = 1;
        }

        return count;
    }
}