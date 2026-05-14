public class Solution {
    private bool IsAlphaNumeric(char c) {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }

    public bool IsPalindrome(string s) {
        StringBuilder strContent = new();

        foreach (char c in s)
            if (IsAlphaNumeric(c))
                strContent.Append(char.ToLower(c));

        string cleanedStr = strContent.ToString();

        strContent.Clear();
        for (int i = cleanedStr.Length - 1; i >= 0; i--) {
            char c = cleanedStr[i];
            strContent.Append(c);
        }
        string reversedStr = strContent.ToString();

        return cleanedStr == reversedStr;
    }
}
