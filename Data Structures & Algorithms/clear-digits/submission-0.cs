public class Solution {
    public string ClearDigits(string s) {
        Stack<char> stack = new();

        foreach (char ch in s) {
            if (char.IsDigit(ch))
                stack.Pop();
            else
                stack.Push(ch);
        }

        char[] result = stack.ToArray();

        Array.Reverse(result);

        return new string(result);
    }
}
