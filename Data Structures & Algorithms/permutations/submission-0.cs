public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new();
        Generate(nums, 0, result);
        return result;
    }

    private void Generate(int[] nums, int pos, List<List<int>> result) {
        int length = nums.Length;

        if (pos == length) {
            // copy the nums and store it to the result
            List<int> leaf = new();
            foreach (int num in nums) {
                leaf.Add(num);
            }
            result.Add(leaf);
            return;
        }

        for (int i = pos; i < length; i++) {
            int t = nums[pos];
            nums[pos] = nums[i];
            nums[i] = t;

            Generate(nums, pos + 1, result);

            t = nums[pos];
            nums[pos] = nums[i];
            nums[i] = t;
        }
    }
}
