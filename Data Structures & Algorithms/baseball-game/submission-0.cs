public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> scores = new Stack<int>();

        foreach (string op in operations) {
            if (op == "+") {
                int top = scores.Pop();
                int newScore = top + scores.Peek();
                scores.Push(top);
                scores.Push(newScore);
            } else if (op == "D")
                scores.Push(2 * scores.Peek());
            else if (op == "C")
                scores.Pop();
            else
                scores.Push(int.Parse(op));
        }

        return scores.Sum();
    }
}