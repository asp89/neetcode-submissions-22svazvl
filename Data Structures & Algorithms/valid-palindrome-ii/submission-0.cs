public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            if (s[left] == s[right]) {
                left++;
                right--;
            } else {
                return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
            }
        }

        return true;
    }

    private bool IsPalindrome(string str, int left, int right) {
        if (left >= right)
            return true;
        if (str[left] != str[right])
            return false;
        return IsPalindrome(str, left + 1, right - 1);
    }
}