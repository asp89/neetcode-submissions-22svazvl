public class Solution {
    public string MinWindow(string s, string t) {
        if(t.Length > s.Length) return "";

        Dictionary<char, int> need = new();
        Dictionary<char, int> window = new();

        foreach (char c in t) {
            need[c] = need.GetValueOrDefault(c, 0) + 1;
        }

        int left = 0;
        int formed = 0;
        int required = need.Count;

        int minLength = int.MaxValue;
        int start = 0;

        for (int right = 0; right < s.Length; right++) {
            char c = s[right];

            window[c] = window.GetValueOrDefault(c, 0) + 1;

            if (need.ContainsKey(c) && window[c] == need[c]) {
                formed++;
            }

            while (formed == required) {
                int length = right - left + 1;

                if (length < minLength) {
                    minLength = length;
                    start = left;
                }

                char leftChar = s[left];
                window[leftChar]--;

                if (need.ContainsKey(leftChar) && window[leftChar] < need[leftChar]) {
                    formed--;
                }

                left++;
            }
        }

        return minLength == int.MaxValue ? "" : s.Substring(start, minLength);
    }
}
