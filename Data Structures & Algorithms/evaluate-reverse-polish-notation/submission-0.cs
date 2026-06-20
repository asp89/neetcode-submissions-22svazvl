public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        String[] operations = new string[] { "+", "-", "*", "/" };

        foreach (string token in tokens) {
            if (operations.Contains(token)) {
                int b = stack.Pop();
                int a = stack.Pop();

                int result = 0;

                if (token == "*")
                    result = a * b;
                else if (token == "+")
                    result = a + b;
                else if (token == "-")
                    result = a - b;
                else if (token == "/")
                    result = a / b;
                else
                    result = 0;

                stack.Push(result);
            }
            else
                stack.Push(int.Parse(token));
        }

        return stack.Pop();
    }
}
