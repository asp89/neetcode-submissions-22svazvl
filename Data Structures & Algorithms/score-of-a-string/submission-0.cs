public class Solution {
    public int ScoreOfString(string s) {
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            // 0, 1, 2
            int currentAscii = (int)s[i];

            if (i + 1 < s.Length) {
                int nextAscii = (int)s[i + 1];
                int val = nextAscii - currentAscii;

                if (val < 0) {
                    result = result + (-val);
                } else {
                    result += val;
                }
            }
        }

        return result;
    }
}