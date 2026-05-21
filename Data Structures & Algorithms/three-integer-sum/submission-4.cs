public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        int length = nums.Length;

        Array.Sort(nums);

        for (int i = 0; i < length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0) {
                    var triplet = new List<int>() { nums[i], nums[left], nums[right] };
                    result.Add(triplet);

                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                } else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }
        return result;
    }
}
