public class Solution {
    public int AppendCharacters(string s, string t) {
        if (s.Length == 0)
            return 0;

        int i = 0, j = 0;

        while (i < s.Length && j < t.Length) {
            if (s[i] == t[j]) {
                i++;
                j++;
            } else {
                i++;
            }
        }

        return t.Length - j;
    }
}