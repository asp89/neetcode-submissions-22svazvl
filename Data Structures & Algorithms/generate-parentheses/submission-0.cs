public class Solution {
    public List<string> GenerateParenthesis(int n) {
        Stack<(string current, int open, int close)> stack = new();

        stack.Push(("", 0, 0));

        List<string> result = new();

        while (stack.Count > 0) {
            var state = stack.Pop();

            // If complete → add to result
            // If we can add '(' → push new state
            // If we can add ')' → push new state

            if (state.open < n) {
                stack.Push((state.current + "(", state.open + 1, state.close));
            }

            if (state.close < state.open) {
                stack.Push((state.current + ")", state.open, state.close + 1));
            }

            if (state.open == n && state.close == n) {
                result.Add(state.current);
                continue;
            }
        }

        return result;
    }
}
