public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums.Length < 2)
            return 0;

        int threshold = nums.Length / 2;

        var map = new Dictionary<int, int>();
        foreach (int num in nums) map[num] = map.TryGetValue(num, out int count) ? count + 1 : 1;

        foreach (var kvp in map) {
            if (kvp.Value >= threshold)
                return kvp.Key;
        }

        return 0;
    }
}