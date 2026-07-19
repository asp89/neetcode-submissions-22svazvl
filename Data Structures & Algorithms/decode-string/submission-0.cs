public class Solution {
    public string DecodeString(string s) {
        Stack<int> countStack = new();
        Stack<StringBuilder> strStack = new();
        StringBuilder currentStr = new();

        int k = 0;

        foreach (char ch in s) {
            if (char.IsDigit(ch))
                k = k * 10 + (ch - '0');
            else if (ch == '[') {
                countStack.Push(k);
                strStack.Push(currentStr);

                currentStr = new();
                k = 0;
            } else if (ch == ']') {
                int repeatTimes = countStack.Pop();
                StringBuilder decodedStr = strStack.Pop();

                for (int i = 0; i < repeatTimes; i++) {
                    decodedStr.Append(currentStr);
                }

                currentStr = decodedStr;
            } else {
                currentStr.Append(ch);
            }
        }

        return currentStr.ToString();
    }
}