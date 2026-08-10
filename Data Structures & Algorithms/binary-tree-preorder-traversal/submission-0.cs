/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> PreorderTraversal(TreeNode root) {
        var result = new List<int>();

        if (root is null)
            return result;
        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0) {
            TreeNode current = stack.Pop();
            result.Add(current.val);

            if (current.right != null)
                stack.Push(current.right);

            if (current.left != null)
                stack.Push(current.left);
        }

        return result;
    }
}