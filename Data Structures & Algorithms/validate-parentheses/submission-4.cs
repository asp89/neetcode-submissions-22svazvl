public class Solution {
    public bool IsValid(string s) {
        Dictionary<string, string> map = new() { [")"] = "(", ["}"] = "{", ["]"] = "[" };
        Stack<string> stack = new();

        foreach (char ch in s) {
            string c = ch.ToString();
            if (map.ContainsValue(c))
                stack.Push(c);
            else {
                if (stack.Count == 0)
                    return false;
                if (stack.Pop() != map[c])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
