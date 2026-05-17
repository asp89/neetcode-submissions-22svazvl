public class Solution {
    private bool IsAlphaNumeric(char c) {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }

    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while (i < j) {
            while (i < j && !IsAlphaNumeric(s[i])) i++;

            while (i < j && j >= 0 && !IsAlphaNumeric(s[j])) j--;

            if (i < s.Length && j >= 0 && i < j)
            {
                char leftChar = char.ToLower(s[i]);
                char rightChar = char.ToLower(s[j]);

                if (rightChar != leftChar)
                    return false;
                
                i++;
                j--;
            }
        }

        return true;
    }
}

