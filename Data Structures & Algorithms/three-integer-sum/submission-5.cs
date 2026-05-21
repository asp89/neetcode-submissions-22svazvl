public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var result = new List<List<int>>();
        var uniqueSet = new HashSet<string>();
        int length = nums.Length;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            
            HashSet<int> seen = new();

            for (int j = i + 1; j < nums.Length; j++)
            {
                int complement = -(nums[i] + nums[j]);

                if (seen.Contains(complement)) {
                    string key = $"{nums[i]},{complement},{nums[j]}";
                    uniqueSet.Add(key);
                }
                seen.Add(nums[j]);
            }
        }

        foreach(string r in uniqueSet)
        {
            string[] parts = r.Split(',');
            result.Add(new List<int>
            {
                int.Parse(parts[0]),
                int.Parse(parts[1]),
                int.Parse(parts[2])
            });
        }
        
        return result;
    }
}
