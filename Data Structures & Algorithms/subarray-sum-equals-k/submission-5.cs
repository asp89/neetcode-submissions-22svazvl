public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int sum = 0, count = 0;
        var map = new Dictionary<int, int>();
        map[0] = 1;

        foreach (int num in nums) {
            sum += num;

            if (map.ContainsKey(sum - k))
                count += map[sum - k];

            map[sum] = map.GetValueOrDefault(sum) + 1;
        }

        return count;
    }
}