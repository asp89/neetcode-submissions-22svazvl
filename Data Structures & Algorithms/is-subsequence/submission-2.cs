public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0)
            return true;

        if (s.Length > t.Length)
            return false;

        int sPtr = 0, tPtr = 0;

        while (tPtr < t.Length) {
            if (s[sPtr] == t[tPtr]) {
                sPtr++;

                if (sPtr == s.Length)
                    return true;
            }
            tPtr++;
        }

        return false;
    }
}