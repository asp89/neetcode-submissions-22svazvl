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

// public class Solution {
//     public IList<int> Postorder(Node root) {
//         List<int> result = new List<int>();
//         if (root == null) return result;

//         Stack<Node> stack = new Stack<Node>();
//         stack.Push(root);

//         while (stack.Count > 0) {
//             Node current = stack.Pop();
//             result.Add(current.val);

//             // Push children from left to right onto the stack
//             // So that the rightmost child is popped and processed next
//             if (current.children != null) {
//                 foreach (var child in current.children) {
//                     if (child != null) {
//                         stack.Push(child);
//                     }
//                 }
//             }
//         }

//         // Reverse the accumulated list to get the correct postorder sequence
//         result.Reverse();
//         return result;
//     }
// }
