public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        var resultSet = new HashSet<string>();

        int length = nums.Length;

        for (int i = 0; i < length; i++) {
            for (int j = i + 1; j < length; j++) {
                for (int k = j + 1; k < length; k++) {
                    if (nums[i] + nums[j] + nums[k] == 0) {
                        var triplet = new List<int>() { nums[i], nums[j], nums[k] };

                        triplet.Sort();

                        string key = string.Join(',', triplet);
                        if (!resultSet.Contains(key)) {
                            resultSet.Add(key);
                            result.Add(triplet);
                        }
                    }
                }
            }
        }

        return result;
    }
}
