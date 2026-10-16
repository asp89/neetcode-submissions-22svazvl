public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = new();

        Build(nums.ToList(), new List<int>(), result);

        return result;
    }

    private void Build(List<int> remaining, List<int> built, List<List<int>> results) {
        if (remaining.Count == 0) {
            results.Add(new List<int>(built));
            return;
        }

        for (int i = 0; i < remaining.Count; i++) {
            int chosen = remaining[i];

            List<int> rest = new(remaining);
            rest.RemoveAt(i);

            built.Add(chosen);
            Build(rest, built, results);
            built.RemoveAt(built.Count - 1);
        }
    }
}
