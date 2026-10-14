public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for (int i = 0; i <= nums.Length - 1; i++) {
            int complement = target - nums[i];

            if (map.TryGetValue(complement, out int prevIndex))
                return [prevIndex, i];

            map[nums[i]] = i;
        }

        return [];
    }
}