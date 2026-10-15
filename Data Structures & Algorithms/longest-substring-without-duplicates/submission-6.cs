public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int i = 0, j = 0, result = 0;
        HashSet<char> set = new();

        while (j < s.Length) {
            if (set.Contains(s[j])) {  //  z - true,
                set.Remove(s[i]);      // 0 -> z
                i++;                   // 1
            } else {
                result = Math.Max(result, j - i + 1);  // 1, 2, 3
                set.Add(s[j]);                         // z, x, y,
                j++;                                   // 0, 1, 2
            }
        }
        
        return result;
    }
}