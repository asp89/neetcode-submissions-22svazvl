public class Solution {
    public int ScoreOfString(string s) {
        int result = 0;

        for (int i = 0; i < s.Length - 1; i++) {
            int currentAscii = (int)s[i];
            int nextAscii = (int)s[i + 1];

            result += Math.Abs(nextAscii - currentAscii);
        }

        return result;
    }
}