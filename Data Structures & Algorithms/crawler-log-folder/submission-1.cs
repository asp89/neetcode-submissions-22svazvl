public class Solution {
    public int MinOperations(string[] logs) {
        Stack<string> stack = new();

        foreach (string log in logs) {
            if (log == "../") {
                if (stack.Count > 0) {
                    stack.Pop();
                }
            } else if (log != "./") {
                stack.Push(log);
            }
        }

        return stack.Count;
    }
}