public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;

        int[] pattern = new int[26];
        int[] window = new int[26];

        foreach (char c in s1) pattern[c - 'a']++;

        for (int i = 0; i < s1.Length; i++) window[s2[i] - 'a']++;

        if (Matches(pattern, window))
            return true;

        for (int right = s1.Length; right < s2.Length; right++) {
            int left = right - s1.Length;

            window[s2[left] - 'a']--;
            window[s2[right] - 'a']++;

            if (Matches(pattern, window))
                return true;
        }
        return false;
    }

    private bool Matches(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }
}
