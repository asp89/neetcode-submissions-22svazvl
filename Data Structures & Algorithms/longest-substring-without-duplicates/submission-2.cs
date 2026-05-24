public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int i = 0, j = 0;
        int result = 0;
        HashSet<char> set = new();

        while (j < s.Length) {
            if (set.Contains(s[j])) {
                set.Remove(s[i]);
                i++;
            } else {
                result = Math.Max(result, j - i + 1);
                set.Add(s[j]);
                j++;
            }
        }

        return result;
    }
}
