public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for (int i = 0; i <= nums.Length - 1; i++) {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
                return [map[complement], i];

            map.Add(nums[i], i);
        }
        return [];
    }
}
