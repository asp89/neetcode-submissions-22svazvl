/*
// Definition for a Node.
public class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<int> Postorder(Node root) {
        List<int> result = new();
        if (root is null)
            return result;

        Stack<Node> stack = new();
        stack.Push(root);

        while (stack.Count > 0) {
            Node current = stack.Pop();
            result.Add(current.val);

            if (current.children != null) {
                foreach (var child in current.children)
                    if (child != null)
                        stack.Push(child);
            }
        }
        result.Reverse();
        return result;
    }
}