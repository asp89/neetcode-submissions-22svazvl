public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        s = s.TrimEnd();

        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == ' ')
                break;

            count++;
        }

        return count;
    }
}