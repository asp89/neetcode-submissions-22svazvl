public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int res = 0;

        for (int i = 0; i < n; i++)
        {
            HashSet<char> set = new();
            for (int j = i; j < n; j++)
            {
                if (set.Contains(s[j]))
                    break;
                set.Add(s[j]);
                res = Math.Max(res, j - i + 1);
            }
        }

        return res;
    }
}
