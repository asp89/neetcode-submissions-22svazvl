public class Solution {
    public string MakeGood(string s) {
        Stack<char> stack = new();

        foreach (char c in s) {
            if (stack.Count > 0 && char.ToUpper(c) == char.ToUpper(stack.Peek()) &&
                c != stack.Peek()) {
                stack.Pop();
            } else {
                stack.Push(c);
            }
        }

        char[] result = stack.ToArray();
        Array.Reverse(result);

        return new string(result);
    }
}
