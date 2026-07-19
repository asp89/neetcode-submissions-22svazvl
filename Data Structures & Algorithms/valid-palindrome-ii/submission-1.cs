public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0, right = s.Length - 1;

        while (left < right) {
            if (s[left] == s[right]) {
                left++;
                right--;
            } else {
                return isPalindrome(s, left + 1, right) || isPalindrome(s, left, right - 1);
            }
        }

        return true;
    }

    private bool isPalindrome(string s, int left, int right) {
        if (left >= right)
            return true;
        if (s[left] != s[right])
            return false;

        return isPalindrome(s, left + 1, right - 1);
    }
}